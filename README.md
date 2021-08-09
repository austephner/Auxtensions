# Auxtensions
### Summary
Helpful extensions and utils for C# Unity development.

### Features
* Extensions for common types that use Unity's `Mathf` class
* Extensions for `string`, `char`, `float`, `int`, `Vector3`/`Vector2`, and more
* Full documentation including examples

### Usage
1. Download the repository into your `Assets` folder (if downloading from Git).
2. Import the Auxtensions namespace in any C# file.

```c#
using Auxtensions;
```

3. Access extensions or util classes as needed (see below examples)

```c#
// Find the closest power of 2 to an integer.
100.ClosestPowerOfTwo();

// Round a float value to an integer.
1.71248f.RoundToInt();

// Calculate the absolute value of each dimension on a Vector3
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

#### Documentation Example
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

### Usage Examples
More examples coming soon!

#### `IList` Extensions
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