# Shiva - Password Cracker and Hashing Tool
This is a simple red team tool marketed towards younger students looking to get involved in CTF challenges. When first starting out in CTF, it can be rather discouraging for new players to learn command-line based password crackers such as John the Ripper. This program gives them a chance to ease into red team tools without feeling burdened with the complexity of other password crackers.

The program is split into two parts, the password cracker, and the hashing tool.

### Hashing Tool
The hashing tool takes user input in the form of a cleartext string and returns a hash value based on the format chosen. Chosen formats available are MD5, SHA-128, SHA-256, and SHA-512. For testing purposes, I compared the results to online hash generators and the results matched.

###### Usage
From the main menu, select hashing tool. Enter a string you would like hashed as well as a hash format found on the left hand side of the window. If desired, select salt length from right hand side. Click Hash button for output.

### Password Cracker
The password cracker takes user input in the form of a hash value. This hash value is then compared to a list of hashes generated from a wordlist provided by the user. For efficieny purposes, the password cracker generates one hash from the wordlist to compare before moving on to the next. This provides an amortized runtime of O(N/2).

The password cracker UI also includes links to well known word lists such as rockyou.txt

###### Usage
From the main menu, select password cracker. Enter a hash you would like to crack. Using the browse menu, select a word list from your system. Click crack button for output. Results may take up to a few minutes.

# UML Diagram
![Screenshot](Shiva%20UML%20Diagram-1.png)

# Test Cases

### MD5Hash
- [x] Hash generation for string "phrase123456" // Expected "6596088e10363a7093d725e76fe705f8" // Result "6596088e10363a7093d725e76fe705f8"
- [x] Hash generation for string "123456789" // Expected "25f9e794323b453885f5181f1b624d0b" // Result "25f9e794323b453885f5181f1b624d0b"
- [x] Hash generation for string "asdfghjkl" // Expected "c44a471bd78cc6c2fea32b9fe028d30a" // Result "c44a471bd78cc6c2fea32b9fe028d30a"
- [x] Hash generation for empty string // Expected message box "Please enter a string." // Result message box "Please enter a string."
- [x] Hash generation with size 2 salt with string "phrase123456" // Expected anything but "6596088e10363a7093d725e76fe705f8" // Result "896a6ac489ae62f28f0f79de61a28543"

### SHA128Hash
- [x] Hash generation for string "phrase123456" // Expected "961f0bfbad8ee7ef3a1f1266ad581693be8131f2" // Result "961f0bfbad8ee7ef3a1f1266ad581693be8131f2"
- [x] Hash generation for string "123456789" // Expected "20ed9777f732fd372425d59afbeaf547ff946038" // Result "20ed9777f732fd372425d59afbeaf547ff946038"
- [x] Hash generation for string "asdfghjkl" // Expected "89e4a4563790aaf4333532b4c7a5beb459ce2fc5" // Result "89e4a4563790aaf4333532b4c7a5beb459ce2fc5"
- [x] Hash generation for empty string // Expected message box "Please enter a string." // Result message box "Please enter a string."
- [x] Hash generation with size 2 salt with string "phrase123456" // Expected anything but "961f0bfbad8ee7ef3a1f1266ad581693be8131f2" // Result "635b3f978d03828788d4d2f8ed284bbd6253f235"

### SHA256Hash
- [x] Hash generation for string "phrase123456" // Expected "7c53d6306ac98812c5d5ff1fdde3fc5c76179cb7afd3d391192ec992d5a1e9f0" // Result "7c53d6306ac98812c5d5ff1fdde3fc5c76179cb7afd3d391192ec992d5a1e9f0"
- [x] Hash generation for string "123456789" // Expected "15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225b" // Result "15e2b0d3c33891ebb0f1ef609ec419420c20e320ce94c65fbc8c3312448eb225"
- [x] Hash generation for string "asdfghjkl" // Expected "5c80565db6f29da0b01aa12522c37b32f121cbe47a861ef7f006cb22922dffa1" // Result "5c80565db6f29da0b01aa12522c37b32f121cbe47a861ef7f006cb22922dffa1"
- [x] Hash generation for empty string // Expected message box "Please enter a string." // Result message box "Please enter a string."
- [x] Hash generation with size 2 salt with string "phrase123456" // Expected anything but "7c53d6306ac98812c5d5ff1fdde3fc5c76179cb7afd3d391192ec992d5a1e9f0" // Result "060ee8633160eff5482874b76748f62a683c78bb50eeb61683c2f385b2281234"

### SHA512Hash
- [x] Hash generation for string "phrase123456" // Expected "f2090eba48418e2c83afbd8d21162f0f586dde628ad66b4d5ea1813a7a37bae135a283e6541f7f29a53001f2600436041e18923d7d165cd693152c2d0e1d43a4" // Result "f2090eba48418e2c83afbd8d21162f0f586dde628ad66b4d5ea1813a7a37bae135a283e6541f7f29a53001f2600436041e18923d7d165cd693152c2d0e1d43a4"
- [x] Hash generation for string "123456789" // Expected "d9e6762dd1c8eaf6d61b3c6192fc408d4d6d5f1176d0c29169bc24e71c3f274ad27fcd5811b313d681f7e55ec02d73d499c95455b6b5bb503acf574fba8ffe85" // Result "d9e6762dd1c8eaf6d61b3c6192fc408d4d6d5f1176d0c29169bc24e71c3f274ad27fcd5811b313d681f7e55ec02d73d499c95455b6b5bb503acf574fba8ffe85"
- [x] Hash generation for string "asdfghjkl" // Expected "9c6d7952755415c26ff3c5dc3cc1ee281b56c8542c8619e1d5133a49387d9b26deab3d0d140849a84ca8d13b34cca329af6878ab27d505ccccd473b3a7c56c2a" // Result "9c6d7952755415c26ff3c5dc3cc1ee281b56c8542c8619e1d5133a49387d9b26deab3d0d140849a84ca8d13b34cca329af6878ab27d505ccccd473b3a7c56c2a"
- [x] Hash generation for empty string // Expected message box "Please enter a string." // Result message box "Please enter a string."
- [x] Hash generation with size 2 salt with string "phrase123456" // Expected anything but "f2090eba48418e2c83afbd8d21162f0f586dde628ad66b4d5ea1813a7a37bae135a283e6541f7f29a53001f2600436041e18923d7d165cd693152c2d0e1d43a4" // Result "5548e6cbe4cf83683789d3656fae3a59ae40e4225838ff788b8dcc7696cf787f7d26ee1fb9f7a964b6e42a72720c3bcb06a79c3db791f9a53834009c994ffdea"

### WordList
- [x] Crack password for MD5 hash "cfeaea3d30fc87fede068121042c9017" // Expected "vspeed" // Result "vspeed"
- [x] Crack password for SHA-156 hash "051059b7441c884cb296f4635e6d155921f8c0fa" // Expected "vspeed" // Result "vspeed"
- [x] Crack password for SHA-256 hash "354cab18f3a67143e3de1963e51fe6bf03d52a7b28924cf37bf0cd7b2b62460a" // Expected "vspeed" // Result "vspeed"
- [x] Crack password for SHA-512 hash "6188c9983ffeaed160b7034d871f5fa52958436bf1141264edc70c8362a6170b42f0a9c9ef9161988de2b1cab2047889964d7835df89c54a4a7d8d7c0d4b587d" // Expected "vspeed" // Result "vspeed"
- [x] Crack password with no hash input // Expected message box "Please enter hash to crack." // Result message box "Please enter hash to crack."
- [x] Crack password with no word list selected // Expected message box "Please select a word list." // Result message box "Please select a word list."


