# C-Practice

view status (Do this between each step)

`git status`

add all files to staging

`git add .`

commit stage area

`git commit -m "Message here"`

push commit to github

`git push`

motto for testing "Red, Green, Refactor"
(do a commit between green and refeactor sometimes)
(*Three or more varibles? put them in a class*)
(F2 to edit the name of a variable, class, enum, function, etc.)
(lowercase for varibles, uppercase for the class)
(Enums are defined outside of a class)
("Line up" the types in a helper function)

# Exercises (Katas)

- Domain modeling (pick a domain, and work out all the classes/enums to model the domain)
- Basic Arthimetic helpers
- Poker card parsing (Parse a "2D", "3H".. into a Card class)
- Sequence abstractions

# "Course"

- Full Poker Kata (unit testing, domain modeling, more complicated systems)
- Sequence Abstractions (map, filter, fold/reduce, compound transformations)
- Personal Project

# Poker Kata Overview

         PARSING                  DETECT-HAND                  RANK-HANDS            PRINT-WINNER
	------------------------------------------------------------------------------------------
        parseCards  ---------------- detectHand 
            |                        /       \
        parseCard            countFaces      countHandKinds
      /           \

extractFace extractSuit