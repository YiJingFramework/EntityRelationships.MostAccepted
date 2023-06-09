﻿using YiJingFramework.EntityRelationships.MostAccepted.GuaToCharacterExtensions;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;

Console.OutputEncoding = System.Text.Encoding.Unicode;

// If you cannot correctly see the outputs below, try modifing your text encodings or fonts.

Console.WriteLine(GuaWith1Line.Parse("1").ToUnicodeChar());
Console.WriteLine();
// Output: ⚊


Console.WriteLine(GuaWith2Lines.Parse("11").ToUnicodeChar());
Console.WriteLine();
// Output: ⚌

Console.WriteLine(GuaTrigram.Parse("111").ToUnicodeChar());
Console.WriteLine();
// Output: ☰

Console.WriteLine(GuaHexagram.Parse("111111").ToUnicodeChar());
Console.WriteLine();
// Output: ䷀

_ = GuaToCharacterExtensions.TryFromUnicodeChar('䷀', out Gua? result);
Console.WriteLine(result);
// Output: 