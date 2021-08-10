# Auxtensions
#### Summary
Helpful extensions for common types in C# Unity development.

#### Features
* Extensions for common types that use Unity's `Mathf` class
* Extensions for `string`, `char`, `float`, `int`, `Vector3`/`Vector2`, and more
* Full documentation including examples

#### Pitfalls
* This API favors usage of `IList<T>` over arrays and `IEnumerables`
* Although minimal, some Linq is used for `IEnumerable` extensions

# General Usage
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

# Contribution
#### Rules
1. Code must follow formatting patterns of the existing codebase to retain consistency.
2. <i>Try to</i> fully document and comment all functions. See below for an example.
3. Code must go through pull requests before being merged. 
4. Commits must list all changes to the codebase separated by commas.
5. Alphabetize functions.
6. Add your name to the contributors list along with any links you'd like to share!

#### Function Documentation Example
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

# Detailed Usage
Please note that this section only covers the majority of complicated functionality. Simple extensions which utilize Unity's `Mathf` library aren't covered as they're self explanatory.

## `IList` Extensions
### `Append()`
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

### `Dequeue<T>()`
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

### `GetRandom<T>()`
Returns a random element from within the list.
```c#
var myList = new List<string>() { "red", "orange", "yellow", "green", "blue" };

var randomColor = myList.GetRandom();

// printing the value of "randomColor" would show one of the values found in "myList"

Debug.Log(randomColor);
```

### `GetRandomByWeight<T>()`
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

### `Shuffle()`
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

### `ShuffleToNew()`
Like `Shuffle()`, this function will take an `IList<T>` and rearrange its items. Instead of directly editing the source list, it'll return a new `IList<T>` with the rearranged elements.
```c#
var myItems = new List<int>() { 0, 1, 2, 3, 4, 5 };

var shuffledItems = myItems.ShuffleToNew();

// printing each element of "shuffledItems" would reveal that they have been rearranged to a new order.

foreach (var item in shuffledItems) 
{
    Debug.Log(item);
}
```

## `IEnumerator` Extensions
### `Then()`
Iterates through one `IEnumerator` then iterates through another `IEnumerator`. Behaves similarly to how one might expect _olde worlde_ Angular promises to work.
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

## `IEnumerable` Extensions
Extensions for the `IEnumerable<T>` types aren't recommended for use due to the fact that they use Linq. Linq is not performant if used extensively. It's recommended to use `IList<T>` instead as arrays aren't supported beyond these `IEnumerable` extensions.
<br><br>
Supported:
- `GetRandom<T>()`
- `GetRandom<T>(IEnumerable<T> exclude)`<br><br>
For more information about these functions, it's recommended to take a look at the `IList` extensions.
  
## `String` Extensions
### `FromJson<T>()`
Returns an object of type `T` using the Unity `JsonUtility` class. Assumes that the string is a serialized JSON object.
```c#
[Serializable]
class Item 
{
    public string name;
    public float dropRate;
}

var stringJson = "{ \"name\":\"Apple\", \"dropRate\":1.0f }";

var item = stringJson.FromJson<Item>();
```
<br>
Note that string extensions include a function for overwriting an existing object too.

### `FromJsonFile<T>()`
Returns an object of type `T` using the Unity `JsonUtility` class. Assumes that the string is a filepath.
```c#
[Serializable]
class Item 
{
    public string name;
    public float dropRate;
}

var filePath = "./Items/Apple.json";

var item = filePath.FromJsonFile<Item>();
```

### `IsNullOrWhiteSpace()`
Returns `true` if this string is null or consists only of whitespace.
```c#
var myString = "    ";

if (myString.IsNullOrWhiteSpace())
{
    Debug.Log("The string is null or whitespace.");
}

// the above code would print the message because "myString" consists only of whitespace.
```

### `IsNullOrEmpty()`
Returns `true` if this string is null or empty.
```c#
var myString = "";

if (myString.IsNullOrWhiteSpace())
{
    Debug.Log("The string is null or whitespace.");
}

// the above code would print the message because "myString" is empty.
```

### `GetLastSplitValue()`
Returns the last occurrence of an element in an array of strings that been split with the given character. This is extremely useful for extracting file names or directories.
```c#
var filePath = "./Configuration/Game/CharacterData.config";

var fileName = filePath.GetLastSplitValue('/');

// printing "fileName" would show "CharacterData.config"

Debug.Log(fileName);
```

### `PopLastSplitValue()`
Removes the last occurrence of an element in an array of strings that have been split with the given character.
```c#
var filePath = "./Configuration/Game/CharacterData.config";

var directoryPath = filePath.PopLastSplitValue('/');

// printing "directoryPath" would show "./Configuration/Game"

Debug.Log(directoryPath);
```

### `CreateRandomStringFromSource()`
Creates a random `string` consisting of characters from this source `string` with the given length. The length can be any size, it simply helps determine how many random results to generate.
```c#
var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

// running this code will print 10 random strings of 3 characters each to the console.

for (int i = 0; i < 10; i++) 
{
    Debug.Log(alphabet.CreateRandomStringFromSource(3));
}
```

## `Vector3` Extensions
### `Abs()`
Calculates a new `Vector3` with absolute values.
```c#
var myVector3 = new Vector3(-10, -20, -100);

var absVector3 = myVector3.Abs();

// printing "absVector3" would show that each field is the absolute value of its respective field from 
// the original "myVector3" variable.

Debug.Log(absVector3);
```

### `ClampAllFields()`
Clamps each field of a `Vector3` to the given min and max `float` value.
```c#
var myVector3 = new Vector3(0.1f, -2.0f, 13.08f);

var clampedVector3 = myVector3.ClampAllFields(-1.0f, 1.0f);

// printing "clampedVector3" would show that each field has been clamped to a value between -1.0f 
// and 1.0f

Debug.Log(clampedVector3);
```

### `ClampMagnitude()`
Clamps the magnitude of a `Vector3` to the given value.
```c#
var myVector3 = new Vector3(0, 10, 0);

var clampedVector3 = myVector3.ClampMagnitude(5);

// printing "myVector3.magnitude" would show that the magnitude is 10.

Debug.Log(myVector3.magnitude);

// printing "clampedVector3.magnitude" would show that the magnitude is 5.

Debug.Log(clampedVector3.magnitude);
```

### `CreateVector2FromVector3xz()`
Creates a new `Vector2` whose `x` field value is the `Vector3`'s `x` field value and `y` field value is the `Vector3`'s `z` field value. This is useful for converting directions between "top down" and "2D".
```c#
var myDirection = new Vector3(0.15f, 0, 0.83f);

var newDirection = myDirection.CreateVector2FromVector3xz();

// printing "newDirection" would show a Vector2 whose x value is the original Vector3's x value and y
// value is the original Vector3's z value.

Debug.Log(newDirection); 
```

### `CreateVector3xzFromVector2()`
Creates a new `Vector3` and assigns its `x` and `z` values from a `Vector2`'s `x` and `y` values. This is useful for converting directions between "2D" and "top down".
```c#
var myDirection = new Vector3();

var anotherDirection = new Vector2(0.13f, 0.87f);

myDirection.CreateVector3xzFromVector2(anotherDirection);

// printing "myDirection" would show that its "x" and "z" field values match "anotherDirection"'s x and y
// field values.

Debug.Log(myDirection);
```

### `CreateVector3xzFromVector3xy()`
Creates a new `Vector3` by essentially flipping the original `Vector3`'s `y` field value to a `z` field value.
```c#
var myDirection = new Vector3(0.15f, 0.13f, 0);

var newDirection = myDirection.CreateVector3xzFromVector3xy();

// printing "newDirection" would show that the "x" field matches "myDirection"'s "x" field and the "z" field 
// matches "myDirection"'s "y" field.

Debug.Log(newDirection);
```

### `GetMax()`
Gets the max value amongst all fields on the `Vector3`.
```c#
var myVector = new Vector3(0.1f, 100, 9001);

var max = myVector.GetMax();

// printing "max" would show "9001" in the console

Debug.Log(max);
```

### `GetMin()`
Gets the min value amongst all fields on the `Vector3`.
```c#
var myVector = new Vector3(0.1f, 100, 9001);

var min = myVector.GetMin();

// printing "min" would show "0.1f" in the console

Debug.Log(min);
```

### `IsInsideRange()`
Checks to see if each field of this `Vector3` are within a given min and max `float` value. Useful for determining input, directional, and physics force related thresholds.
```c#
var userInput = new Vector3(0.15f, 0.935f);

if (userInput.IsInsideRange(-1.0f, 1.0f)) 
{
    Debug.Log("User is sending valid input.");
}
```

### `IsMagnitudeInsideRange()`
Checks to see if this `Vector3`'s magnitude is within a 0 and max `float` value range. Useful for determining speed of movement or deltas.
```c#
var carSpeed = new Vector3(13, 0, 0.95f);

if (carSpeed.IsMagnitudeInsideRange(20)) 
{
    Debug.Log("Player is going the speed limit.");
}
```

### `IsMagnitudeOutsideRange()`
Checks to see if this `Vector3`'s magnitude is outside of a 0 to max `float` value range. Useful for determining speed of movement or deltas.
```c#
var carSpeed = new Vector3(13, 0, 0.95f);

if (carSpeed.IsMagnitudeOutsideRange(20)) 
{
    Debug.Log("Player is speeding! Send the police!");
}
```

### `IsOutsideRange()`
Checks to see if each field of this `Vector3` are outside a given min and max `float` value. Useful for determining input, directional, and physics force related thresholds.
```c#
var userInput = new Vector3(0.15f, 0.935f);

if (userInput.IsOutsideRange(-0.5f, 0.5f)) 
{
    Debug.Log("User is sending valid input.");
}
```

### `RandomizeByRange()`
Randomizes all fields on a `Vector3` given a min and max.
```c#
var myVector3 = new Vector3(0, 1, 10);

var max = myVector3.GetMax();

myVector3.RandomizeByRange(0, max);

// printing "myVector3" would show that each field in "myVector3" has been randomized.

Debug.Log(myVector3);
```

### `RoundToMultipleOf()`
Rounds each field of of a `Vector3` to a multiple of the given value.
```c#
var myVector3 = new Vector3(0.15f, 10.0f, 25.0f);

var rounded = myVector3.RoundToMultipleOf(2);

// printing "rounded" to the console would show that the Vector3's "x" field is 0, the "y" field remains 
// as 10, and the "z" field is rounded to 24.

Debug.Log(rounded);
```

### `TransformDirection()`
Calculates a new direction relative to a `Transform`.
```c#
var worldDirection = new Vector3(0.15f, 0.0f, 0.98f);

Transform someTransform;

var relativeDirection = worldDirection.Transform(someTransform);

// printing "relativeDirection" would show that the direction has changed relative to the transform.

Debug.Log(relativeDirection);
```

## `Vector2` Extensions
Coming soon!

## `Float` Extensions
Coming soon!

## `Int` Extensions
Coming soon!

## `Char` Extensions
Coming soon!