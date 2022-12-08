# Shiva - Password Cracker and Hashing Tool
This is a simple red team tool marketed towards younger students looking to get involved in CTF challenges. When first starting out in CTF, it can be rather discouraging for new players to learn command-line based password crackers such as John the Ripper. This program gives them a chance to ease into red team tools without feeling burdened with the complexity of other password crackers.

The program is split into two parts, the password cracker, and the hashing tool.

### Hashing Tool
The hashing tool takes user input in the form of a cleartext string and returns a hash value based on the format chosen. Chosen formats available are MD5, SHA-128, SHA-256, and SHA-512. For testing purposes, I compared the results to online hash generators and the results matched.

### Password Cracker
The password cracker takes user input in the form of a hash value. This hash value is then compared to a list of hashes generated from a wordlist provided by the user. For efficieny purposes, the password cracker generates one hash from the wordlist to compare before moving on to the next. This provides an amortized runtime of O(N/2).

# UML Diagram
![alt text](https://github.com/jteerice/Shiva-Password-Cracker-and-Hashing-Tool/blob/master/Shiva%20UML%20Diagram.pdf)
