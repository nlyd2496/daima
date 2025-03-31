using HarmonyLib;
using System.Text;
using System.Threading.Tasks;
using PeterHan.PLib.Options;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P_基础系统_1._0
{
    public class Patches
    {
        private static CellOffset O(int x, int y)
        {
            return new CellOffset(x, y);
        }
        private static readonly CellOffset[][] TableExpansion = new CellOffset[][]
        {
            new CellOffset[]
            {
                Patches.O(5, 0)
            },
            new CellOffset[]
            {
                Patches.O(5, 1)
            },
            new CellOffset[]
            {
                Patches.O(5, 2)
            },
            new CellOffset[]
            {
                Patches.O(5, 3)
            },
            new CellOffset[]
            {
                Patches.O(5, 4)
            },
            new CellOffset[]
            {
                Patches.O(5, 5)
            },
            new CellOffset[]
            {
                Patches.O(5, -1)
            },
            new CellOffset[]
            {
                Patches.O(5, -2)
            },
            new CellOffset[]
            {
                Patches.O(5, -3)
            },
            new CellOffset[]
            {
                Patches.O(5, -4)
            },
            new CellOffset[]
            {
                Patches.O(5, -5)
            },
            new CellOffset[]
            {
                Patches.O(-5, 0)
            },
            new CellOffset[]
            {
                Patches.O(-5, 1)
            },
            new CellOffset[]
            {
                Patches.O(-5, 2)
            },
            new CellOffset[]
            {
                Patches.O(-5, 3)
            },
            new CellOffset[]
            {
                Patches.O(-5, 4)
            },
            new CellOffset[]
            {
                Patches.O(-5, 5)
            },
            new CellOffset[]
            {
                Patches.O(-5, -1)
            },
            new CellOffset[]
            {
                Patches.O(-5, -2)
            },
            new CellOffset[]
            {
                Patches.O(-5, -3)
            },
            new CellOffset[]
            {
                Patches.O(-5, -4)
            },
            new CellOffset[]
            {
                Patches.O(-5, -5)
            },
            new CellOffset[]
            {
                Patches.O(4, 0)
            },
            new CellOffset[]
            {
                Patches.O(4, 1)
            },
            new CellOffset[]
            {
                Patches.O(4, 2)
            },
            new CellOffset[]
            {
                Patches.O(4, 3)
            },
            new CellOffset[]
            {
                Patches.O(4, 4)
            },
            new CellOffset[]
            {
                Patches.O(4, 5)
            },
            new CellOffset[]
            {
                Patches.O(4, -1)
            },
            new CellOffset[]
            {
                Patches.O(4, -2)
            },
            new CellOffset[]
            {
                Patches.O(4, -3)
            },
            new CellOffset[]
            {
                Patches.O(4, -4)
            },
            new CellOffset[]
            {
                Patches.O(4, -5)
            },
            new CellOffset[]
            {
                Patches.O(-4, 0)
            },
            new CellOffset[]
            {
                Patches.O(-4, 1)
            },
            new CellOffset[]
            {
                Patches.O(-4, 2)
            },
            new CellOffset[]
            {
                Patches.O(-4, 3)
            },
            new CellOffset[]
            {
                Patches.O(-4, 4)
            },
            new CellOffset[]
            {
                Patches.O(-4, 5)
            },
            new CellOffset[]
            {
                Patches.O(-4, -1)
            },
            new CellOffset[]
            {
                Patches.O(-4, -2)
            },
            new CellOffset[]
            {
                Patches.O(-4, -3)
            },
            new CellOffset[]
            {
                Patches.O(-4, -4)
            },
            new CellOffset[]
            {
                Patches.O(-4, -5)
            },
            new CellOffset[]
            {
                Patches.O(3, 0)
            },
            new CellOffset[]
            {
                Patches.O(3, 1)
            },
            new CellOffset[]
            {
                Patches.O(3, 2)
            },
            new CellOffset[]
            {
                Patches.O(3, 3)
            },
            new CellOffset[]
            {
                Patches.O(3, 4)
            },
            new CellOffset[]
            {
                Patches.O(3, 5)
            },
            new CellOffset[]
            {
                Patches.O(3, -1)
            },
            new CellOffset[]
            {
                Patches.O(3, -2)
            },
            new CellOffset[]
            {
                Patches.O(3, -3)
            },
            new CellOffset[]
            {
                Patches.O(3, -4)
            },
            new CellOffset[]
            {
                Patches.O(3, -5)
            },
            new CellOffset[]
            {
                Patches.O(-3, 0)
            },
            new CellOffset[]
            {
                Patches.O(-3, 1)
            },
            new CellOffset[]
            {
                Patches.O(-3, 2)
            },
            new CellOffset[]
            {
                Patches.O(-3, 3)
            },
            new CellOffset[]
            {
                Patches.O(-3, 4)
            },
            new CellOffset[]
            {
                Patches.O(-3, 5)
            },
            new CellOffset[]
            {
                Patches.O(-3, -1)
            },
            new CellOffset[]
            {
                Patches.O(-3, -2)
            },
            new CellOffset[]
            {
                Patches.O(-3, -3)
            },
            new CellOffset[]
            {
                Patches.O(-3, -4)
            },
            new CellOffset[]
            {
                Patches.O(-3, -5)
            },
            new CellOffset[]
            {
                Patches.O(2, 0)
            },
            new CellOffset[]
            {
                Patches.O(2, 1)
            },
            new CellOffset[]
            {
                Patches.O(2, 2)
            },
            new CellOffset[]
            {
                Patches.O(2, 3)
            },
            new CellOffset[]
            {
                Patches.O(2, 4)
            },
            new CellOffset[]
            {
                Patches.O(2, 5)
            },
            new CellOffset[]
            {
                Patches.O(2, -1)
            },
            new CellOffset[]
            {
                Patches.O(2, -2)
            },
            new CellOffset[]
            {
                Patches.O(2, -3)
            },
            new CellOffset[]
            {
                Patches.O(2, -4)
            },
            new CellOffset[]
            {
                Patches.O(2, -5)
            },
            new CellOffset[]
            {
                Patches.O(-2, 0)
            },
            new CellOffset[]
            {
                Patches.O(-2, 1)
            },
            new CellOffset[]
            {
                Patches.O(-2, 2)
            },
            new CellOffset[]
            {
                Patches.O(-2, 3)
            },
            new CellOffset[]
            {
                Patches.O(-2, 4)
            },
            new CellOffset[]
            {
                Patches.O(-2, 5)
            },
            new CellOffset[]
            {
                Patches.O(-2, -1)
            },
            new CellOffset[]
            {
                Patches.O(-2, -2)
            },
            new CellOffset[]
            {
                Patches.O(-2, -3)
            },
            new CellOffset[]
            {
                Patches.O(-2, -4)
            },
            new CellOffset[]
            {
                Patches.O(-2, -5)
            },
            new CellOffset[]
            {
                Patches.O(1, 0)
            },
            new CellOffset[]
            {
                Patches.O(1, 1)
            },
            new CellOffset[]
            {
                Patches.O(1, 2)
            },
            new CellOffset[]
            {
                Patches.O(1, 3)
            },
            new CellOffset[]
            {
                Patches.O(1, 4)
            },
            new CellOffset[]
            {
                Patches.O(1, 5)
            },
            new CellOffset[]
            {
                Patches.O(1, -1)
            },
            new CellOffset[]
            {
                Patches.O(1, -2)
            },
            new CellOffset[]
            {
                Patches.O(1, -3)
            },
            new CellOffset[]
            {
                Patches.O(1, -4)
            },
            new CellOffset[]
            {
                Patches.O(1, -5)
            },
            new CellOffset[]
            {
                Patches.O(-1, 0)
            },
            new CellOffset[]
            {
                Patches.O(-1, 1)
            },
            new CellOffset[]
            {
                Patches.O(-1, 2)
            },
            new CellOffset[]
            {
                Patches.O(-1, 3)
            },
            new CellOffset[]
            {
                Patches.O(-1, 4)
            },
            new CellOffset[]
            {
                Patches.O(-1, 5)
            },
            new CellOffset[]
            {
                Patches.O(-1, -1)
            },
            new CellOffset[]
            {
                Patches.O(-1, -2)
            },
            new CellOffset[]
            {
                Patches.O(-1, -3)
            },
            new CellOffset[]
            {
                Patches.O(-1, -4)
            },
            new CellOffset[]
            {
                Patches.O(-1, -5)
            },
            new CellOffset[]
            {
                Patches.O(0, 1)
            },
            new CellOffset[]
            {
                Patches.O(0, 2)
            },
            new CellOffset[]
            {
                Patches.O(0, 3)
            },
            new CellOffset[]
            {
                Patches.O(0, 4)
            },
            new CellOffset[]
            {
                Patches.O(0, 5)
            },
            new CellOffset[]
            {
                Patches.O(0, -1)
            },
            new CellOffset[]
            {
                Patches.O(0, -2)
            },
            new CellOffset[]
            {
                Patches.O(0, -3)
            },
            new CellOffset[]
            {
                Patches.O(0, -4)
            },
            new CellOffset[]
            {
                Patches.O(0, -5)
            },
            new CellOffset[]
            {
                Patches.O(0, 0)
            }
        };
        private static bool OffsetsExpanded = false;
        public static bool SHOULDSHRINK = false;
        [HarmonyPatch(typeof(Game), "OnPrefabInit")]
        public static class GamePatch
        {
            public static void Postfix()
            {
                bool P004GG1 = SingletonOptions<控制台>.Instance.P004GG1;
                if (P004GG1)
                {
                    Patches.GamePatch.ExpandTables();
                }
            }
            public static void ExpandTables()
            {
                if (!Patches.OffsetsExpanded)
                {
                    Patches.GamePatch.ExpandTable(ref OffsetGroups.InvertedStandardTable);
                    Patches.GamePatch.ExpandTable(ref OffsetGroups.InvertedStandardTableWithCorners);
                    Patches.OffsetsExpanded = true;
                }
            }
            public static void ExpandTable(ref CellOffset[][] inputTable)
            {
                CellOffset[][] array = OffsetTable.Mirror(Enumerable.ToArray<CellOffset[]>(Enumerable.Concat<CellOffset[]>(Enumerable.ToList<CellOffset[]>(inputTable), Patches.TableExpansion)));
                inputTable = array;
            }
            public static bool Equals(CellOffset[] a, CellOffset[] b)
            {
                bool result;
                if (a == null || b == null || a.Length != b.Length || a.Length == 0)
                {
                    result = false;
                }
                else
                {
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (!a[i].Equals(b[i]))
                        {
                            return false;
                        }
                    }
                    result = true;
                }
                return result;
            }
            public static bool Contains(CellOffset[][] table, CellOffset[] array)
            {
                for (int i = 0; i < table.Length; i++)
                {
                    if (Patches.GamePatch.Equals(table[i], array))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
