# BinaryHeapCsharp
Binary Heap for C# that can be used as a priority queue with test code that proves the correctness of the implementation.

PriorityQueue is a very useful structure currently missing from C# standard collections. 
Thereby, I hope this implementation will help people like me who were suprised to see that there is no standard priority queue implementation for C#.

This is a generic implementation that accepts types that implement IComparable (this essentially includes all the primitives). 
I prefer this implementation from other implementation available online because most of the other implementation don't support IComparable and the user has to provide the priority as a parameter to the insertion function. 
I find a generic class that accepts IComparable types much more convenient. For instance imagine doing heap.insert(1,1) instead of just heap.insert(1). Seems a bit weird right?

This is a VisualStudio 2015  project. 

The implemented function are the standard heap operation which are :

insert
peek (return the minimum or maximum node but dont remove it from heap)
extractRootNode (return and remove the minimum or the maximum node)

Also other helpful function are implemented like specifying min or max heap in constructor, isEmpty, clear(), and Count property which is equal to the number of items currently in heap.

Below is the output of the Test.cs which proves the correctness of the implementation (the test is for a min heap)

Insertion Order

Added 215 currentPeak 215
Added 243 currentPeak 215
Added 228 currentPeak 215
Added 163 currentPeak 163
Added 53 currentPeak 53
Added 163 currentPeak 53
Added 270 currentPeak 53
Added 127 currentPeak 53
Added 293 currentPeak 53
Added 74 currentPeak 53
Added 80 currentPeak 53
Added 134 currentPeak 53
Added 186 currentPeak 53
Added 135 currentPeak 53
Added 294 currentPeak 53
Added -1 currentPeak -1
Added 257 currentPeak -1
Added 298 currentPeak -1
Added 199 currentPeak -1
Added 87 currentPeak -1
Added 243 currentPeak -1
Added 252 currentPeak -1
Added 297 currentPeak -1
Added 0 currentPeak -1
Added 206 currentPeak -1
Added 153 currentPeak -1
Added 279 currentPeak -1
Added 203 currentPeak -1
Added 159 currentPeak -1
Added 15 currentPeak -1
Added 48 currentPeak -1
Added 130 currentPeak -1
Added 82 currentPeak -1
Added 296 currentPeak -1
Added 189 currentPeak -1
Added 226 currentPeak -1
Added -1 currentPeak -1
Added 108 currentPeak -1
Added 96 currentPeak -1
Added 286 currentPeak -1
Added 146 currentPeak -1
Added 211 currentPeak -1
Added 26 currentPeak -1
Added 74 currentPeak -1
Added 271 currentPeak -1
Added 236 currentPeak -1
Added 94 currentPeak -1
Added 131 currentPeak -1
Added 35 currentPeak -1
Added 58 currentPeak -1
Added 117 currentPeak -1
Added 212 currentPeak -1
Added 182 currentPeak -1
Added 141 currentPeak -1
Added 50 currentPeak -1
Added 262 currentPeak -1
Added 245 currentPeak -1
Added 217 currentPeak -1
Added 256 currentPeak -1
Added 200 currentPeak -1
Added 183 currentPeak -1
Added 57 currentPeak -1
Added 267 currentPeak -1
Added 267 currentPeak -1
Added 16 currentPeak -1
Added 249 currentPeak -1
Added 42 currentPeak -1
Added 189 currentPeak -1
Added 246 currentPeak -1
Added 57 currentPeak -1
Added 299 currentPeak -1
Added 139 currentPeak -1
Added 192 currentPeak -1
Added 213 currentPeak -1
Added 240 currentPeak -1
Added 21 currentPeak -1
Added 216 currentPeak -1
Added 212 currentPeak -1
Added 28 currentPeak -1
Added 270 currentPeak -1
Added 48 currentPeak -1
Added 137 currentPeak -1
Added 157 currentPeak -1
Added 90 currentPeak -1
Added 198 currentPeak -1
Added 135 currentPeak -1
Added 248 currentPeak -1
Added 240 currentPeak -1
Added 236 currentPeak -1
Added 226 currentPeak -1
Added 280 currentPeak -1
Added 81 currentPeak -1
Added 152 currentPeak -1
Added 195 currentPeak -1
Added 93 currentPeak -1
Added 78 currentPeak -1
Added 244 currentPeak -1
Added 58 currentPeak -1
Added 47 currentPeak -1
Added 11 currentPeak -1

Extraction Order

-1
-1
0
11
15
16
21
26
28
35
42
47
48
48
50
53
57
57
58
58
74
74
78
80
81
82
87
90
93
94
96
108
117
127
130
131
134
135
135
137
139
141
146
152
153
157
159
163
163
182
183
186
189
189
192
195
198
199
200
203
206
211
212
212
213
215
216
217
226
226
228
236
236
240
240
243
243
244
245
246
248
249
252
256
257
262
267
267
270
270
271
279
280
286
293
294
296
297
298
299
Press enter to close...


