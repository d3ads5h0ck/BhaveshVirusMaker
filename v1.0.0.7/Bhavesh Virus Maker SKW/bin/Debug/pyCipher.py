# IMPLEMENTATION OF CAESAR CIPHER IN PYTHON

print(50 * "+")
print("")
print("pyCipher by Bhavesh Kaul".center(50))
print("")
print(50 * "+")

print("NOTE: This code is open and was found on the internet! I'm not the original creator of this source code for encryption and decryption python program.\n")
print("")
print("I will add new functions such as storing the text in a txt file.")

MAX_KEY_SIZE = 26
def getMode():
	while True:
		print('Encrypt or Decrypt? [e, d] >> ')
		mode = input().lower()
		if mode in 'encrypt e decrypt d'.split():
			return mode
		else:
			print('Enter either "e" or "d" >> ')
			
def getMessage():
	print('Enter your Text >> ')
	return input()

def getKey():
	key = 0
	while True:
		print('Enter the key number (1-%s)' % (MAX_KEY_SIZE))
		key = int(input())
		if(key >= 1 and key <= MAX_KEY_SIZE):
			return key
			
def getTranslatedMessage(mode, message, key):
	if mode[0] == 'd':
		key = -key
	translated = ''
	
	for symbol in message:
		if symbol.isalpha():
			num = ord(symbol)
			num += key
			
			if symbol.isupper():
				if num > ord('Z'):
					num -= 26
				elif num < ord('A'):
					num += 26
			elif symbol.islower():
				if num > ord('z'):
					num -= 26
				elif num < ord('a'):
					num += 26
			
			translated += chr(num)
		else:
			translated += symbol
	return translated
mode = getMode()
message = getMessage()
key = getKey()

print('Your Translated Text Is: ')
print(getTranslatedMessage(mode, message, key))