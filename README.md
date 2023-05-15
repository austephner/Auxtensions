# Auxtensions (1.1.1)
#### Summary
Helpful auxiliary extensions for common types in C# Unity development. The code and documentation is currently a work in progress, but functions are named obviously enough. **Please leave feedback and feel free to make critiques as I improve this repo!**

#### Features
* Extensions for a multitude of types
* Extensions for common usages of Unity's `Mathf` class in relation to `int` and `float`
* Extensions to replace static functions for `Vector3` and `Quaternion` 
* Seriously, there's so many extensions...
* Additional utility classes for common operations
* Almost entirely documented

#### All Supported Types
* `string`
* `char`
* `float`
* `int`
* `Vector2` & `Vector3`
* `Quaternion`
* `IList`
* `IEnumerable`
* `IEnumerator`
* `IDictionary`

#### Pitfalls
* This API favors usage of `IList<T>` over arrays and `IEnumerables`
* Some `Linq` is used for `IEnumerable` extensions. You can avoid it by using `IList<T>`

#### Todos
* Documentation
* Complete list of intended extensions
* Function attributes for IDE and dev insight
* Support for arrays, not just `IList` and `IEnumerable` (coming in version 1.1.x)

# All Functions by Type
TODO (there's a lot)

# Usage
1. Install the package with Package Manager OR download the repository into your `Assets` folder (if downloading from Git) 
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

// Get a new Vector3 full of the absolute values of the current one
new Vector3(-1, -23, 400).Abs();
```

4. ???
5. Profit

# Examples
Note that this isn't an exhaustive list, the API has dozens of extension methods not listed here.
## Floats

```c#
// Remap or normalize values
var myCrazyFloat = 173.81245f; 
var remapped = myCrazyFloat.Remap(0.0f, 200.0f, 0.0f, 1.0f);

// Check if this float is outside of a range
var anotherCrazyFloat = 1.618f; 
if (anotherCrazyFloat.IsOutsideRange(0.0f, 1.0f)) 
{
    Debug.Log("Wow, it's out of the range.");
}

// Clamp this float to a maximum value, ensuring it never goes over
var wowAnotherCrazyFloat = 12757.0812f;
var clamped = wowAnotherCrazyFloat.ClampToMax(100.0f);

// Quickly round a float
var howManyCrazyFloatsAreThere = 8125.812882882f;
var rounded = howManyCrazyFloatsAreThere.RoundToInt();

// Move this value towards another value
var velocity = 15.08f;
velocity = velocity.MoveTowards(20.0f, Time.deltaTime * 10.0f);
```

## Ints
Extensions for `int` typed variables exist, but the documentation is coming soon. It's basically the same (and a little more) as the `float` extensions.

## IList<T>
```c#
// Get a random item from a list
var list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var randomInt = list.Random();

// Shuffle
var list = new List<int> { 5, 10, 15, 20 };
list.Shuffle();

// Dequeue the item in front, like a Queue<T>
var list = new List<int> { 9, 8, 7, 6, 5 };
var next = list.Dequeue();

// Remove items in the list that meet the criteria
var list = new List<string> { "Hello", "Test", "Yeup" };
list.RemoveWhere(item => item.Length > 4);
```
#### Random Weighted Selection
The following example would require configuration through the editor. It shows how to setup a weighted prefab random selector though.
```c#
using UnityEngine;
using Auxtensions;
using System.Collections.Generic;

public class MyBehaviour : MonoBehaviour 
{
    [SerializeField] private List<WeightedPrefab> _weightedPrefabs;
    
    public GameObject GetRandomWeightedPrefab() 
    {
        return _weightedPrefabs.RandomByWeight(item => item.weight);
    }
}

[CreateAssetMenu(menuName = "Weighted Prefab")]
public class WeightedPrefab : ScriptableObject
{
    public GameObject prefab;
    public float weight;
}

```

## Strings
```c#
// Easily convert from/to JSON with serializable objects
var json = "{ \"fieldName\": \"value\" }";
var myObj = json.FromJson<MySerializableClass>();

// Quickly check "is null or whitespace"
var emptyString = "      ";
if (emptyString.IsNullOrWhiteSpace()) 
{
    Debug.Log("String is null or whitespace!");
}

// Try to parse a string to an int
var numberString = "100";
if (numberString.TryParseToInt(out var result))
{
    Debug.Log("Yep, it's a number");
}

// Get a prefab from a path
var myPrefabResourcePath = "Resources/MyPrefab"; 
var resource = myPrefabResourcePath.LoadResource();

// or asynchronously...
var resourceRequest = myPrefabResourcePath.LoadResourceAsync();
```

## Char
```c#
// Check is digit, special character, period, etc. 
var c = 'A'; 
if (c.IsDigit() || c.IsPeriod() || c.IsWhiteSpace || c.IsSpecialCharacter()) 
{
    Debug.Log("Everything is A-O-K.");
}

// Check if letter
var c = '1'; 
if (c.IsLetter()) 
{
    Debug.Log("It's a letter.");
}
else 
{
    Debug.Log("It's not a letter.");
}
```

## Vectors
#### Vector2
More `Vector2` extensions will be added in time. A lot of the `Vector3` extensions can be applied to `Vector2` as well, it's just not prioritized work right now.
```c#
// Get a random float based in the range from X to Y
var vector2 = new Vector2(-1.0f, 1.0f);
var value = vector2.RandomFloatFromRange();
```

#### Vector3
```c#
// Clamp the magnitude of a Vector3 
var currentVelocity = new Vector3(-1.0f, 12.0f, 0.3f);
var clampedVelocity = currentVelocity.ClampMagnitude(5.0f);

// Convert a Vector3 with values in its X and Y fields to a Vector3 with values in its X and Z fields
var vector = new Vector3(1.0f, 12.0f);
var topDownVector = vector.ToVector3xzFromVector3xy();

// Check if all values on a Vector3 are within a float range
var velocity = new Vector3(12.0f, 0.0f, 1.0f);
if (velocity.IsMagnitudeInsideRange(0.0f, 1.0f)) 
{
    Debug.Log("Player is walking.");
}
else 
{
    Debug.Log("Player isn't walking.");
}
```

## Enumerators
Checkout [Coroutine Utils](https://github.com/austephner/CoroutineUtils) because it has the same vibe.
```c#
private void Start() 
{
    StartCoroutine(MyCoroutine().Then(AnotherCoroutine());
}

private IEnumerator MyCoroutine() 
{
    Debug.Log("Hello World");
}

private IEnumerator AnotherCoroutine() 
{
    Debug.Log("Whoop");
}
```