# EnumerableUtility.RangeTo method (1 of 2)

Returns a range of integers.

```csharp
public static IEnumerable<int> RangeTo(int start, int stop)
```

| parameter | description |
| --- | --- |
| start | The initial value. |
| stop | The final value. |

## Return Value

A sequence of values starting with the initial value and ending with the final value.

## Remarks

This method will increment or decrement, as necessary. If the initial and final values are the same, the sequence contains only that value.

## See Also

* class [EnumerableUtility](../EnumerableUtility.md)
* namespace [Faithlife.Utility](../../Faithlife.Utility.md)

---

# EnumerableUtility.RangeTo&lt;T&gt; method (2 of 2)

Returns a range of values.

```csharp
public static IEnumerable<T> RangeTo<T>(T start, T stop, Func<T, T> increment)
```

| parameter | description |
| --- | --- |
| T | The type of object in the sequence. |
| start | The initial value. |
| stop | The final value. |
| increment | Increments the value. |

## Return Value

A sequence of values starting with the initial value and ending with the final value.

## Remarks

If the initial and final values are the same, the sequence contains only that value.

## See Also

* class [EnumerableUtility](../EnumerableUtility.md)
* namespace [Faithlife.Utility](../../Faithlife.Utility.md)

<!-- DO NOT EDIT: generated by xmldocmd for Faithlife.Utility.dll -->