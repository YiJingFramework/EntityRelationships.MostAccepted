﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.PrimitiveTypes;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount;
using YiJingFramework.PrimitiveTypes.GuaWithFixedCount.Extensions;

namespace YiJingFramework.EntityRelationships.MostAccepted.GuaToTextExtensions;
public static partial class GuaToCharacterExtensions
{
    // Generated in project GuaToCharacterGenerating

    private static char SwitchToUnicodeChar(GuaHexagram gua)
    {
        return gua.GetHashCode() switch {
            64 => '\u4dc1',
            65 => '\u4dd6',
            66 => '\u4dc7',
            67 => '\u4dd3',
            68 => '\u4dcf',
            69 => '\u4de2',
            70 => '\u4dec',
            71 => '\u4dcb',
            72 => '\u4dce',
            73 => '\u4df3',
            74 => '\u4de6',
            75 => '\u4df4',
            76 => '\u4dfd',
            77 => '\u4df7',
            78 => '\u4dde',
            79 => '\u4de0',
            80 => '\u4dc6',
            81 => '\u4dc3',
            82 => '\u4ddc',
            83 => '\u4dfa',
            84 => '\u4de7',
            85 => '\u4dff',
            86 => '\u4dee',
            87 => '\u4dc5',
            88 => '\u4ded',
            89 => '\u4dd1',
            90 => '\u4def',
            91 => '\u4df8',
            92 => '\u4ddf',
            93 => '\u4df1',
            94 => '\u4ddb',
            95 => '\u4deb',
            96 => '\u4dd7',
            97 => '\u4dda',
            98 => '\u4dc2',
            99 => '\u4de9',
            100 => '\u4df2',
            101 => '\u4dd4',
            102 => '\u4dd0',
            103 => '\u4dd8',
            104 => '\u4de3',
            105 => '\u4dd5',
            106 => '\u4dfe',
            107 => '\u4de4',
            108 => '\u4df6',
            109 => '\u4ddd',
            110 => '\u4df0',
            111 => '\u4dcc',
            112 => '\u4dd2',
            113 => '\u4de8',
            114 => '\u4dfb',
            115 => '\u4dfc',
            116 => '\u4df5',
            117 => '\u4de5',
            118 => '\u4df9',
            119 => '\u4dc9',
            120 => '\u4dca',
            121 => '\u4dd9',
            122 => '\u4dc4',
            123 => '\u4dc8',
            124 => '\u4de1',
            125 => '\u4dcd',
            126 => '\u4dea',
            127 => '\u4dc0',
            _ => throw new Exception(
                "This should not happen in any cases. " +
                "Please contact us to report the problem."),
        };
    }

    private static Gua SwitchFromUnicodeChar(int hexagramDifference)
    {
        var yang = Yinyang.Yang;
        var yin = Yinyang.Yin;
        return hexagramDifference switch {
            0 => new Gua(yang, yang, yang, yang, yang, yang),
            1 => new Gua(yin, yin, yin, yin, yin, yin),
            2 => new Gua(yang, yin, yin, yin, yang, yin),
            3 => new Gua(yin, yang, yin, yin, yin, yang),
            4 => new Gua(yang, yang, yang, yin, yang, yin),
            5 => new Gua(yin, yang, yin, yang, yang, yang),
            6 => new Gua(yin, yang, yin, yin, yin, yin),
            7 => new Gua(yin, yin, yin, yin, yang, yin),
            8 => new Gua(yang, yang, yang, yin, yang, yang),
            9 => new Gua(yang, yang, yin, yang, yang, yang),
            10 => new Gua(yang, yang, yang, yin, yin, yin),
            11 => new Gua(yin, yin, yin, yang, yang, yang),
            12 => new Gua(yang, yin, yang, yang, yang, yang),
            13 => new Gua(yang, yang, yang, yang, yin, yang),
            14 => new Gua(yin, yin, yang, yin, yin, yin),
            15 => new Gua(yin, yin, yin, yang, yin, yin),
            16 => new Gua(yang, yin, yin, yang, yang, yin),
            17 => new Gua(yin, yang, yang, yin, yin, yang),
            18 => new Gua(yang, yang, yin, yin, yin, yin),
            19 => new Gua(yin, yin, yin, yin, yang, yang),
            20 => new Gua(yang, yin, yin, yang, yin, yang),
            21 => new Gua(yang, yin, yang, yin, yin, yang),
            22 => new Gua(yin, yin, yin, yin, yin, yang),
            23 => new Gua(yang, yin, yin, yin, yin, yin),
            24 => new Gua(yang, yin, yin, yang, yang, yang),
            25 => new Gua(yang, yang, yang, yin, yin, yang),
            26 => new Gua(yang, yin, yin, yin, yin, yang),
            27 => new Gua(yin, yang, yang, yang, yang, yin),
            28 => new Gua(yin, yang, yin, yin, yang, yin),
            29 => new Gua(yang, yin, yang, yang, yin, yang),
            30 => new Gua(yin, yin, yang, yang, yang, yin),
            31 => new Gua(yin, yang, yang, yang, yin, yin),
            32 => new Gua(yin, yin, yang, yang, yang, yang),
            33 => new Gua(yang, yang, yang, yang, yin, yin),
            34 => new Gua(yin, yin, yin, yang, yin, yang),
            35 => new Gua(yang, yin, yang, yin, yin, yin),
            36 => new Gua(yang, yin, yang, yin, yang, yang),
            37 => new Gua(yang, yang, yin, yang, yin, yang),
            38 => new Gua(yin, yin, yang, yin, yang, yin),
            39 => new Gua(yin, yang, yin, yang, yin, yin),
            40 => new Gua(yang, yang, yin, yin, yin, yang),
            41 => new Gua(yang, yin, yin, yin, yang, yang),
            42 => new Gua(yang, yang, yang, yang, yang, yin),
            43 => new Gua(yin, yang, yang, yang, yang, yang),
            44 => new Gua(yin, yin, yin, yang, yang, yin),
            45 => new Gua(yin, yang, yang, yin, yin, yin),
            46 => new Gua(yin, yang, yin, yang, yang, yin),
            47 => new Gua(yin, yang, yang, yin, yang, yin),
            48 => new Gua(yang, yin, yang, yang, yang, yin),
            49 => new Gua(yin, yang, yang, yang, yin, yang),
            50 => new Gua(yang, yin, yin, yang, yin, yin),
            51 => new Gua(yin, yin, yang, yin, yin, yang),
            52 => new Gua(yin, yin, yang, yin, yang, yang),
            53 => new Gua(yang, yang, yin, yang, yin, yin),
            54 => new Gua(yang, yin, yang, yang, yin, yin),
            55 => new Gua(yin, yin, yang, yang, yin, yang),
            56 => new Gua(yin, yang, yang, yin, yang, yang),
            57 => new Gua(yang, yang, yin, yang, yang, yin),
            58 => new Gua(yin, yang, yin, yin, yang, yang),
            59 => new Gua(yang, yang, yin, yin, yang, yin),
            60 => new Gua(yang, yang, yin, yin, yang, yang),
            61 => new Gua(yin, yin, yang, yang, yin, yin),
            62 => new Gua(yang, yin, yang, yin, yang, yin),
            63 => new Gua(yin, yang, yin, yang, yin, yang),
            _ => throw new Exception(
                "This should not happen in any cases. " +
                "Please contact us to report the problem."),
        };
    }
}
