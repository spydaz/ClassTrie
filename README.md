
# Welcome to the ClassTrie wiki!

This creation Is the data trie.... A TREE....

In this issue the alphabet trie is created ; The strings are added by character with a STOP character at the end of the insert;

A Search function will be created ; to search the trie for words or search a string for words contained in the trie; ADDED

This method will be further extended to handle numerical inserts as well as DATA inserts for usage as a Conversation Trie;

I was searching for a method to combine various conversation trees; into a single tree; 

This will be it!
# The Trie "TRY"Tree #

The word trie is an inflix of the word “retrieval”, because the trie can find a single word in a dictionary with only a prefix of the word.

The Trie Tree is a very straight forward data structure. It is a simple tree where the nodes have an alphabet associated with them. It is sometimes called a "Prefix tree" / "Suffix tree" .... 

By structuring the nodes in a particular way, words or strings can be retrieved from the structure by traversing down a branch path of the tree.

_ Currently Tries are used for Storing "Characters" within a String... Although these does not need to be the case; Sentences can also be stored (Each Word in a Node) ; Paragraphs can be Stored (Sentences in every node) ; Even Structured Data can be stored in a Trie tree. (using the NODES as Addresses, Data stored in the Final node); _

![Trie Tree Example](https://i1.wp.com/theoryofprogramming.com/wp-content/uploads/2015/06/trie12.jpg)

This offering Attempts to cater for all paradigms ; Noticeably the differences are only measured by the Insertion / Search / Deletion Process. 

**### For advanced Search capabilities data can be added iteratively. ###**
For a single word of Three letters (3 insertions)
Cat > at > T 

This allows for all suffix and Prefixes to be stored in the Tree. 
A Marker is used to Mark the end of a String Entry... 

_CAT(StopChar)_
_AT(StopChar)_
_T(StopChar)_

Where as if a single Insertion is used 

_CAT(StopChar) Cat / Ca / C  <<<< Maybe found > But!_
_At / T <<<< Cannot_

Carpet <contains prefix > Car < But cannot Find Suffix > Pet < 


## Common functions are ;

_**Find Prefix **_

_**Find Suffix *_

_**Count Nodes **_

_**Deepest Node **_

_**Add(by character) > As Single / Iteratively**_

_**Add(by Word) > As Single / Iteratively**_

_**Add(by Sentence) > As Single / Iteratively**_

***UPDATES *** 
## WORKING!! ##

**Insert function;**

**FindPrefix function;**

**FindWord Function; **

**CreateTrie Function; **

**ToString Function (displays contents of tree in report form);**

**ToView Function (displays Contents of Tree in TreeviewControl);**



Saved as STRUCTURE; 

Note To extend This structure (just update the CharID to accomodate NewStringID, as well as Update ADD Function)

Probably the NodeID Pointer can be removed (Not Req)

_Project build 1 was as class library (for Sharing)_
_Project build 2 was as EXE (for testing) _
_Built With .net 4.52_

**02/06/2018
Updated Trie to Tree (Universal Tree)
Function ADD / Find Prefix / Find Word / CountWords / Count Node - StopChar nodes / Find Lowest Node - StopChar**

NEEDS - DELETE WORD CMD - 

**Universal Tree -**
 can also Hold Data at nodes using an Alphabetical Tree.....
To be Added.
 **(Input Data @ StopChar)(GetData From StopChar)**
Then Given a CharacterString Address (Data can be Added or Removed or located) Searching Should be done Via CharacterString (Not Data) or GetNode @ CharString Address (Edit/Remove)


**ADDED BINARY TREE**
POSTORDER / PREORDER TRAVERSAL / INSERT / CONTAINS 
**ADDED EXTENSIONS FOR TREENODE OPERATONS)**

**UPDATES COMMITED **;
** ADDWORD ... Adds word iteratively ie: carpet/arpet/rpet/pet/et/t    WORKING **;
<<<<< Contains all possible prefixes in tree from word ** WORKING **;
Various methods counting Nodes / find deepest nodes / Count Prefixs in tree / CountWords in Tree /  ** WORKING **;

*ADDED ::: Add Sentence To TRIE: Breaks sentence into words adding each word to the trie ; 
Sentences can be added as a single branch or as iterative branch "The cat sat on the mat", "cat sat on the mat", "sat on the mat", "on the mat", "the mat", "Mat".*
