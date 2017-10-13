from idautils import *
from idaapi import *

def get_string(addr):
	out = ""
	while True:
		if Byte(addr) != 0:
			out += chr(Byte(addr))
		else:
			break
		addr += 1
	return out

def get_string_from_head(head):
	refs = DataRefsFrom(head)
	for ref in refs:
		refs2 = DataRefsFrom(ref)
		for ref2 in refs2:
			stringval = get_string(ref2)
			return stringval
  
def get_string_from_babyhead(head):
	refs = DataRefsFrom(head)
	for ref in refs:
		stringval = get_string(ref)
		return stringval
map = {}
def dumpkvp(functionName, addr, key):
	if 'getMissionPlateFileName' in functionName:
		return
	if functionName.count('_') == 1 and key in functionName:
		for (startea, endea) in Chunks(addr):
			for head in Heads(startea, endea):
				if 'mov' in GetDisasm(head):
					operand = GetDisasm(head)
					if operand.count(':') == 0:
						continue						
					functionName = functionName[3:]
					if functionName.count('Mst') == 0:
						continue
					functionName = functionName[:functionName.index('Mst') + 3]
					functionName = ''.join([i for i in functionName if not i.isdigit()])
					stringval = get_string_from_head(head)
					if not (functionName in map):
						if not stringval:
							stringval = 'F_BATTLE_SCRIPT_MST'
						map[functionName] = stringval
						files[map[functionName]] = {}
					else:
						files[map[functionName]][key[4:]] = stringval

files = {}
for funcea in Functions(0xb00000, 0x13ea010):
	functionName = GetFunctionName(funcea)
	dumpkvp(functionName, funcea, 'MstName')	
for funcea in Functions(0xb00000, 0x13ea010):
	functionName = GetFunctionName(funcea)
	dumpkvp(functionName, funcea, 'FileName')
	dumpkvp(functionName, funcea, 'FileKey')
	
for addr in Functions(0xb00000, 0x13ea010):
	functionName = GetFunctionName(addr)
	if 'sub_FE51E0' in functionName:
		stringval = ""
		name = ""
		key = ""
		for (startea, endea) in Chunks(addr):
			for head in Heads(startea, endea):
				operand = GetDisasm(head)
				if 'mov' in operand and 'ds:(off' in operand:
					stringval = get_string_from_head(head)
				if 'lea' in operand and not (stringval is ''):
					if key is '':
						key = get_string_from_babyhead(head)
					else:
						name = get_string_from_babyhead(head)
						files[stringval] = {}
						files[stringval]['Name'] = name
						files[stringval]['Key'] = key
						key = ''
						stringval = ''
			
sc = string_info_t()
for addr in Functions(0xb00000, 0x2000000):
	functionName = GetFunctionName(addr)
	if '_ZN15VersionInfoListC2Ev' in functionName:
		stringval = ""
		name = ""
		key = ""
		for (startea, endea) in Chunks(addr):
			for head in Heads(startea, endea):
				operand = GetDisasm(head)
				if 'mov' in operand and 'ds:(off' in operand:
					if 'eax' in operand:
						stringval = get_string_from_head(head)
					if 'ecx' in operand:
						name = get_string_from_head(head)
						if stringval in files:
							continue
						files[stringval] = {}
						files[stringval]['Name'] = name



def dumpkey(addr):
	for (startea, endea) in Chunks(addr):
		i = 0
		for head in Heads(startea, endea):
			i = i + 1
			if i > 0x10:
				continue
			operand = GetDisasm(head)
			if 'mov' in operand and 'ds:(off' in operand:
				return get_string_from_head(head)
	return ''

start = idaapi.get_segm_by_name(".data.rel.ro.local").startEA
end = idaapi.get_segm_by_name(".data.rel.ro").endEA
print hex(start)
print hex(end)
a = 0x024548B4 
print hex(a), ' ', hex(idc.Dword(a)), ' ', idc.Name(idc.Dword(a)), ' : ', dumpkey(idc.Dword(a))
for addr in range(start, end):
	pointeraddr = idc.Dword(addr)
	pointername = idc.Name(pointeraddr)
	if not ('sub_' in pointername or 'loc_' in pointername):
		continue
	stringval = dumpkey(pointeraddr)
	if '_MST' in stringval or 'F_TEXT' in stringval:
		if stringval in files:
			if 'Key' in files[stringval]:
				continue
		#name = files[stringval]['Name']
		name = dumpkey(idc.Dword(addr + 4))
		key = dumpkey(idc.Dword(addr + 8))
		#if name == nextstringval:
		files[stringval] = {}
		if not ('Name' in files[stringval]):
			files[stringval]['Name'] = name
		files[stringval]['Key'] = key

#print files
import json
filename = os.path.expanduser("~/OneDrive/Documents/GitHub/BraveHaxvius/DataExtractor/files2.json")
with open(filename, 'w') as fp:
    json.dump(files, fp)