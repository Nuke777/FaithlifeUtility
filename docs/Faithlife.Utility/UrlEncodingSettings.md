# UrlEncodingSettings class

Stores settings used for encoding and decoding URL-style strings.

```csharp
public sealed class UrlEncodingSettings
```

## Public Members

| name | description |
| --- | --- |
| [UrlEncodingSettings](UrlEncodingSettings/UrlEncodingSettings.md)() | Initializes a new instance of the [`UrlEncodingSettings`](UrlEncodingSettings.md) class. |
| static [HttpUtilitySettings](UrlEncodingSettings/HttpUtilitySettings.md) { get; } | Returns a [`UrlEncodingSettings`](UrlEncodingSettings.md) object that matches the behavior of `HttpUtility.UrlEncode(string)` in .NET 4. |
| [EncodedBytePrefixChar](UrlEncodingSettings/EncodedBytePrefixChar.md) { get; set; } | Gets or sets the character used as the prefix for each encoded byte. |
| [EncodedSpaceChar](UrlEncodingSettings/EncodedSpaceChar.md) { get; set; } | Gets or sets the character used when encoding a space. |
| [PreventDoubleEncoding](UrlEncodingSettings/PreventDoubleEncoding.md) { get; set; } | True if the encoder should prevent double-encoding. |
| [ShouldEncodeChar](UrlEncodingSettings/ShouldEncodeChar.md) { get; set; } | Gets or sets the delegate used to determine whether a character should be encoded or not. |
| [TextEncoding](UrlEncodingSettings/TextEncoding.md) { get; set; } | Gets or sets the text encoding used when encoding or decoding bytes. |
| [UppercaseHexDigits](UrlEncodingSettings/UppercaseHexDigits.md) { get; set; } | Gets or sets a value indicating whether hex digits are encoded in uppercase. |
| [Clone](UrlEncodingSettings/Clone.md)() | Clones this instance. |

## See Also

* namespace [Faithlife.Utility](../Faithlife.Utility.md)
* [UrlEncodingSettings.cs](https://github.com/Faithlife/FaithlifeUtility/tree/master/src/Faithlife.Utility/UrlEncodingSettings.cs)

<!-- DO NOT EDIT: generated by xmldocmd for Faithlife.Utility.dll -->