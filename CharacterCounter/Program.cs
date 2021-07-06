using System;
using System.Collections.Generic;

namespace CharacterCounter {
    class Program {
        static string[] strings = new string[] {
"rznmudAcfQJALZUQZqPJ",
"IrEQRDwFMcYBDahKbzgC",
"HBoZnbqoGSxltFwRXKjH",
"qclXsjxnzGpfAcBDupwV",
"RnixpSVqafaIllIltOyK",
"LbQxiWhKwqtKTOvTkkHl",
"ODgKrkdYsfJPRRxetoIy",
"DNSDcxrdjxlKqccPEzqi",
"WIcoehJKCkSDyGgdBqpY",
"jZxTPoMNgWzsWmcGgHNw",
"pMoHVtQddwynAhiwAbmd",
"DNXwJOWmDkhpugabOwjp",
"LpeMzQpqRIbKozbcXpmv",
"PGizIhwDNJlQYnzkauZm",
"xowohUKXbwzdqCVqSBfv",
"NvPMhbDyIjAGPsBvjAEg",
"UvEnpcXWSwaJpWYkneks",
"YlStgnovpXTnHJZkXDUf",
"VgIZMgJnfIOtRnPRVSSn",
"pIywxqLlTWytOnzymHfg",
"CqzFWHKAfCLLafRkhglE",
"EFogGzYVfFnIkTEyRNjh",
"KjNFeEIHzeEstGyECwFu",
"hICByteiKmlhWFNGszyA",
"HdeOYczkDLymLWckxiBJ",
"TnuIcRGJHZVgHuxnkktO",
"XEUerbXWdgwcGPUhPzLV",
"KmyDJahKIJeGvDczElPu",
"briWqrDSuhDWqlPYuCzq",
"JSZlIcvCNYAdSMfpngYu",
"XgitRfxjkGZQORQGzRcj",
"ppvTnlGVInsioumZAcgD",
"WlAKuBETWiYYZrnplbgu",
"LxLhdzNYaXHQajBbduBI",
"dKCJrdeBjqsOURPfLTea",
"vcuVLuipqDhHqaNKLIej",
"NOeKllZUHOwFHxnZPFne",
"JqhweTQQDUIbmggyOnEd",
"rthqWdSiEmiumcHkOdsF",
"BaZyhhhKDCvkFCuVPYDn",
"kRTbRPYatFeMDnwNUMCx",
"tLTjnCJLgjKEjqBdnvoS",
"ZtHPMSoVDPAMeCKacuQo",
"xTKpzldxxcGipiLFqGXL",
"EJDITqZNmdkjMkBlRiNr",
"qOPVrHuNpmIfcsewZdQM",
"EHeLrExAbqjMQsokZaAE",
"RVVDswZQzSuzDDiARycC",
"DbVwEaMorXtHjnQoZePQ",
"HJEqDrHLFaTmYuODVFGk",
"XnuuRrViRZvVgiHYasrb",
"HOECHnUaYEsZDlmEEoYG",
"ttvVDYrsVhjQJkoazMdy",
"BqikNCEQlYxMuzyRWdRX",
"HWaahxPMOplxuJWtACHf",
"FdImyzofzqCYDJfWGkUJ",
"FHtdnxHHVfvyhqLJaNqn",
"cnxvlHLQwXPOdlHpAcmk",
"oKadLxJbBUKgyoGYzkhJ",
"EkYruLghbXdggJNDVlIy",
"eLjBUPKZDtHycoYyWiAW",
"JgYazmeznFxqBOhadgTc",
"CaQtYCZvjkxasJIcFUGW",
"mnwBvOXbVShRCMjAdlXs",
"zAQDfwYxgRnWFKGlYUSv",
"LnsmkeIfWvqhhmzrEzSZ",
"BsUDfukrUfTUbiRsPzYp",
"kObAeLktYxoqJCIvauhA",
"baYesOdgNXpNooahHZku",
"bZufbRyDSmbbVngLudPc",
"RftuFrzIYFczHytejpHI",
"QFlnZYNKNJARJQSqGBeD",
"gCrgdtFVkKVokComQnWy",
"lskjLAMNcDZhwIwOXXgO",
"erATBNkHvsiOYYfXfSTg",
"ucekVhZSdVjuuGqVJRmC",
"NIMOAHJXkBGLDFQMUCUI",
"GppkxdwnntjtjHChXKJc",
"iSEJefUFBgrgZlbSbckl",
"plOpiCqiZbTIfmTRHBzi",
"HobGeYfblEkbQVnflslr",
"guhwbRCVNXeUIjbyyhzK",
"eCLpDBvjPbReDHBRaQfn",
"ODuwUWBlVQVIQHWGqwEX",
"gkQqtHHZdIjMlFKKdtHv",
"gQdWYUpiZjASmTrmeGlo",
"svyEWezWFTmnrURwgPty",
"poOmzeLXnUTMyRfhwSAB",
"UOLrIgvzsaZmrmHuHYFw",
"qxiBWCDWqAMPqMbrOXxR",
"CaRlZGPGWuKnEQEduoEA",
"QnmoawMCyOJpWhsKKhMs",
"iFuyqrBlQAmxiMrtZdlS",
"BvJpCUIpxbbOGaihbMYp",
"qwFvGUWygPkGFfCLnjLT",
"OPTsxdoDzXBlRxxlsXmb",
"LNdTHLnwWNHMidIcCCTD",
"gekUeUhvvtMhbExngIST",
"pdXVFqucEIprQdhNSnRs",
"MqDUMNbIFnqaQkcKonAW"
};
        static Dictionary<char, int> StringCount = new Dictionary<char, int>();
        static int[] ints = new int[] {
            9879,5134,4662,6558,6951,6997,4634,9757,1691,8777,
            3996,4444,2508,8223,2205,5722,1026,6355,5487,6506,
            8748,5575,4434,3178,9094,6040,1669,5188,8927,3687,
            3767,2294,8467,4892,8657,2279,5424,9410,3492,4042,
            4919,5716,5858,2387,4218,7600,6063,9734,5282,1235,
            5527,8661,2139,5867,9729,4593,8522,5246,4329,8429,
            6919,5212,7215,3049,6722,2566,1834,2946,8306,6154,
            9542,7389,3825,3985,2385,5367,1393,7362,8701,5754,
            7453,5542,7657,6706,7116,4781,7050,3668,3812,6168,
            5035,1380,1164,4120,4146,7290,3518,7581,6727,5657
        };
        static void Main(string[] args) {
            Dictionary<int, int> evenodd = new Dictionary<int, int>();
            evenodd.Add(2, 0);
            evenodd.Add(1, 0);
            foreach(var i in ints) {
                if(i % 2 == 0) { // even
                    evenodd[2]++;
                } else {
                    evenodd[1]++;
                }
            }
            Console.WriteLine($"{evenodd[2]} even, {evenodd[1]} odd.");
        }
        
        static void CountLetters() { 
            //foreach (var str in strings) {
            //    foreach (var ch in str.ToCharArray()) {
            //        var chr = Convert.ToChar(ch.ToString().ToLower());
            //        if (StringCount.ContainsKey(chr)) {
            //            StringCount[chr]++;
            //            continue;
            //        }
            //        StringCount.Add(chr, 1);
            //    }
            //}
        }
    }
}
