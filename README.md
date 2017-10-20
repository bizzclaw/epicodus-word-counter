| Specification                                                                   | Example Input                                               | Example Output                                   |
|---------------------------------------------------------------------------------|-------------------------------------------------------------|--------------------------------------------------|
| Users entered word and phrase will be displayed to them                         | User Enters a word as "day" and the phrase "its a nice day" | Word: day phrase: its a nice day                 |
| the count of the specific word within the phrase will be  displayed             | "day", "this day is a nice day"                             | two counts of "day"                              |
| the counter will be able to count regardless of capitlization                   | "Day", "this is a nice day"                                 | one count of "Day"                               |
| the counter will be able to differentiate between partial words and whole words | "day", "toDAY is a good day"                                | one count of day (the day in "today" is ignored) |
