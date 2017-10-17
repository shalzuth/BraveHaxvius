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
  
def dumpkvp(functionName, addr, key):
	if key in functionName and 'Request' in functionName:
		functionName = functionName[3:]
		functionName = functionName[:functionName.index(key)]
		functionName = ''.join([i for i in functionName if not i.isdigit()])
		functionName = functionName[:len(functionName)-7]
		for (startea, endea) in Chunks(addr):
			for head in Heads(startea, endea):
				operand = GetDisasm(head)
				if  'R0, [PC,R0]' in operand:
				#if  ', =(' in operand:
					stringval = get_string_from_head(head)
					if key is 'getUrl':
						stringval = stringval[14:22]
					if 'action' in stringval:
						stringval = 'action'
					if not (functionName in requests):
						requests[functionName] = {}
					requests[functionName][key[3:]] = stringval
				if  'aActionsymbol' in operand:
					stringval = get_string_from_head(head)
					if key is 'getUrl':
						stringval = stringval[14:22]
					if 'action' in stringval:
						stringval = 'action'
					if not (functionName in requests):
						requests[functionName] = {}
					requests[functionName][key[3:]] = stringval
					
					
def dumpbody(functionName, addr, key):
	if key in functionName and 'Request' in functionName:
		functionName = functionName[3:]
		functionName = functionName[:functionName.index(key)]
		functionName = ''.join([i for i in functionName if not i.isdigit()])
		functionName = functionName[:len(functionName)-7]
		stringval = ""
		basenode = ""
		for (startea, endea) in Chunks(addr):
			for head in Heads(startea, endea):
				operand = GetDisasm(head)
				if 'mov' in operand and 'ds:(off' in operand:
					stringval = get_string_from_head(head)
				if '_ZN9JsonGroup7addNodeEv' in operand:
					if not (functionName in requests):
						requests[functionName] = {}
					if not ("Parameters" in requests[functionName]):
						requests[functionName]["Parameters"] = {}
					basenode = stringval
					requests[functionName]["Parameters"][basenode] = {}
				if '_ZN8JsonNode8addParamEPK' in operand:
					requests[functionName]["Parameters"][basenode] = stringval
					

requests = {}

for funcea in Functions(0x100000, 0x14ea010):
	functionName = GetFunctionName(funcea)
	dumpkvp(functionName, funcea, 'getUrl')
	dumpkvp(functionName, funcea, 'getRequestID')
	dumpkvp(functionName, funcea, 'getEncodeKey')
	#dumpbody(functionName, funcea, 'createBody')
print requests
import json
filename = os.path.expanduser("~/OneDrive/Documents/GitHub/BraveHaxvius/DataExtractor/network2.json")
with open(filename, 'w') as fp:
    json.dump(requests, fp)