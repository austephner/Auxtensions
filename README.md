# Auxtensions
### Summary
Helpful extensions and utils for C# Unity development.

### Features
* Extensions for common types that use Unity's `Mathf` class
* Extensions for `string`, `char`, `float`, `int`, `Vector3`/`Vector2`, and more
* Full documentation including examples

### General Usage
1. Download the repository into your `Assets` folder (if downloading from Git).
2. Import the Auxtensions namespace into a C# file.

```c#
using Auxtensions;
```

3. Access extensions or util classes as needed (see below examples)

```c#
// Find the closest power of 2 to an integer.
(100).ClosestPowerOfTwo();

// Round a float value to an integer.
(1.71248f).RoundToInt();

// Reassign the value of each dimension on a Vector3 to its absolute value.
new Vector3(-1, -23, 400).Abs();
```

4. ???
5. Profit

### Contribution Rules
1. Code must follow formatting patterns of the existing codebase to retain consistency.
2. <i>Try to</i> fully document and comment all functions. See below for an example.
3. Code must go through pull requests before being merged. 
4. Commits must list all changes to the codebase separated by commas.
5. Alphabetize functions.
6. Add your name to the contributors list along with any links you'd like to share!

#### Code Documentation Example
* Summary tag
* Tags for all parameters
* Use "\<see ...>" tags with a `cref` reference to other functions, types, code, etc.
* "Returns" tag
* "Example" tag when needed
```c#
/// <summary>
///     Rounds this <see cref="float"/> to an <see cref="int"/> using <see cref="Mathf.RoundToInt"/>.
/// </summary>
/// <param name="value">
///     This <see cref="float"/> value.
/// </param>
/// <returns>
///     A rounded <see cref="int"/>.
/// </returns>
/// <example>
///     (1.8215f).RoundToInt()
/// </example>
public static int RoundToInt(this float value) => Mathf.RoundToInt(value);
```

The function would then appear like this within JetBrains Rider: <br>
![Documentation Example](https://i.imgur.com/4aeRhiw.png)

#### Contributors & Credits
* Austin Renner ([website](https://www.austephner.com/), [GitHub](https://github.com/austephner))

### Detailed Usage
Right now, the documentation only covers complex and potentially confusing functionality. More examples and code will be added over time.

#### `IList` Extensions
##### `Append()`
Adds all elements of one list into another list without using Linq.
```c#
var listA = new List<int>() { 0, 1, 2, 3 };

var listB = new List<int>() { 4, 5, 6 };

listA.Append(listB);

// printing "listA" would show all original elements along with all elements from "listB"

foreach (var item in listA) 
{
    Debug.Log(item);
} 
```

##### `Dequeue<T>()`
Removes the first item from a list and returns it. This replicates behaviour seen in `Queue` collections.
```c#
var myList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var firstItem = myList.Dequeue();

// printing the value of "firstItem" would be "0"

Debug.Log(firstItem);

// printing each element of "myList" would show that "0" is no longer contained inside

for (int i = 0; i < myList.Count; i++) 
{
    Debug.Log(myList[i]);
}
```

##### `GetRandom<T>()`
Returns a random element from within the list.
```c#
var myList = new List<string>() { "red", "orange", "yellow", "green", "blue" };

var randomColor = myList.GetRandom();

// printing the value of "randomColor" would show one of the values found in "myList"

Debug.Log(randomColor);
```

##### `GetRandomByWeight<T>()`
Returns a random element from within the list, taking into account the item's weight (or it's "chance" of being picked).
```c#
class Item 
{
    public string name;
    public float dropRate;
}

var items = new List<Item>()
{
    new Item() { name = "Apple", dropRate = 1.0f },
    new Item() { name = "Peach", dropRate = 2.0f },
    new Item() { name = "Banana", dropRate = 0.5f }
};

var randomItem = items.GetRandomByWeight(item => item.dropRate);

// printing the value of "randomItem.name" may reveal the "Peach" item more often than the "Apple" and "Banana" because 
// it has the highest weight of 2.0f

Debug.Log(randomItem.name);
```

##### `Shuffle()`
Rearranges all items within an `IList<T>`, effectively shuffling them.
```c#
var myItems = new List<int>() { 0, 1, 2, 3, 4, 5 };

myItems.Shuffle();

// printing each element of "myItems" would reveal that they have been rearranged to a new order.

foreach (var item in myItems) 
{
    Debug.Log(item);
}
```

##### `ShuffleToNew()`
Like `Shuffle()`, this function will take an `IList<T>` and rearrange its items. Instead of editing the source item, it'll return a new `IList<T>` with the rearranged elements.
```c#
var myItems = new List<int>() { 0, 1, 2, 3, 4, 5 };

var shuffledItems = myItems.ShuffleToNew();

// printing each element of "shuffledItems" would reveal that they have been rearranged to a new order.

foreach (var item in shuffledItems) 
{
    Debug.Log(item);
}
```

#### `IEnumerator` Extensions
##### `Then()`
Iterates through one `IEnumerator` then iterates through another `IEnumerator`. Behaves similarly to how one might expect olde worlde Angular promises to work.
```c#
IEnumerator Print10() 
{
    for (int i = 0; i < 10; i++) 
    {
        Debug.Log(i + 1);
        yield return null;
    }
}

IEnumerator PrintDone() 
{
    Debug.Log("Done");
    yield break;
}

GameObject someGameObject;

someGameObject.StartCoroutine(Print10().Then(PrintDone());
```

Alternatively, an `Action` can be used instead of another `IEnumerator`. The original `Then()` function has been overloaded to handle both parameters. 

```c#
IEnumerator Print10() 
{
    for (int i = 0; i < 10; i++) 
    {
        Debug.Log(i + 1);
        yield return null;
    }
}

GameObject someGameObject;

someGameObject.StartCoroutine(Print10().Then(() => Debug.Log("Done"));
```

#### `IEnumerable` Extensions
Extensions for the `IEnumerable<T>` types aren't recommended for use due to the fact that they use Linq. Linq is not performant if used extensively. It's recommended to use `IList<T>` instead as arrays aren't supported beyond these `IEnumerable` extensions.
<br><br>
Supported:
- `GetRandom<T>()`
- `GetRandom<T>(IEnumerable<T> exclude)`<br><br>
For more information about these functions, it's recommended to take a look at the `IList` extensions.
  
#### `String` Extensions
WIP

#### `Float` Extensions
Most `float` extensions are very self-explanatory. This section will be updated over time.

#### `Int` Extensions.
Most `int` extensions are very self-explanatory. This section will be updated over time.