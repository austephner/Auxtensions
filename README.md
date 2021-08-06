# Flintor
### Summary
Helpful C# `float`, `int`, and `Vector3`/`Vector2` extensions for Unity development.

### Features
* Extensions for common types that use Unity's `Mathf` class
* Additional extension functions that are useful
* Full documentation including examples

### Usage
1. Download the repository into your `Assets` folder (if downloading from Git)
2. Import the Flintex namespace

```c#
using Flintor;
```

3. Access `int`, `float`, and `Vector2`/`Vector3` extension methods as needed.

```c#
// Find the closest power of 2 to an integer.
var myInt = 100;
Debug.Log(myInt.ClosestPowerOfTwo());

// Round a float value to an integer.
var myFloat = 1.71248f;
Debug.Log(myFloat.RoundToInt());

// Apply Mathf.Abs(...) to all values of the Vector3
var myVector3 = new Vector3(-1, -23, 400);
Debug.Log(myVector3.Abs());
```

4. ???
5. Profit

### Contribution Rules
1. Code must follow formatting patterns of the existing codebase to retain consistency.
2. <i>Try to</i> fully document and comment all functions. See below for an example.
3. Code must go through pull requests before being merged. 
4. Commits must list all changes to the codebase separated by commas.
5. Alphabetize functions

#### Documentation Example
* Summary tag
* Tags for all parameters
* Uses "<see>" with a `cref` reference to other functions or code
* Returns tag
* Example tag
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
