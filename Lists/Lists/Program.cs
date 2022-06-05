// Different implementations of lists

using Lists.ArrayLists;
using Lists.CircularLinkedLists;
using Lists.GenericLists;
using Lists.LinkedLists;
using Lists.SortedLists;
using Lists.Utils;

var arrayLists = new ArrayLists();
Printer.PrintSection("Arraylist can hold different information\nAvoid the usage of them");
arrayLists.FillList();
arrayLists.PrintList();
Printer.PrintNote(
    "You can use the methods Count and Capacity, they work in a different way\nbut there are some peculiar behaviors, see reference in book.");
arrayLists.ArrayListOperations();
Printer.PrintNote("You can also use methods like: Remove, RemoveAt and RemoveRange");


Printer.PrintSection("Generic Lists are similar than Lists or ArrayLists but strongly typed");
var genericLists = new GenericLists();
genericLists.AverageValue();
genericLists.ListOfPeople();

Printer.PrintSection("Sorted lists are key-value pair lists automatically sorted by the key");
var sortedLists = new SortedLists();
sortedLists.AddressBook();

Printer.PrintSection(
    "Linked lists are list in where one element has a pointer to the next\nand the previous element, there also exists the First and Last element\nSee book for a clearer explanation");
var linkedLists = new LinkedLists();
Printer.PrintNote("There are few operations that are worth to consider:");
Printer.PrintBulletPoint("AddFirst: For adding an element at the beginning of the list");
Printer.PrintBulletPoint("AddLast: For adding an element at the end of the list");
Printer.PrintBulletPoint("AddBefore: For adding an element before the specified node in the list");
Printer.PrintBulletPoint("AddAfter: For adding an element after the specified node in the list");
Printer.PrintNote("All these methods return an instance of the LinkedListNode class.");
linkedLists.BookReader();

Printer.PrintSection("A circular linked lists is a custom data structure that uses the LinkedLists as its core");
var circularLinkedLists = new CircularLinkedLists();
circularLinkedLists.SpinTheWheel();