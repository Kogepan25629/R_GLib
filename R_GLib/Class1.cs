/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_GLib
{

    // H8のシュミレータ本体
    class H8Main
    {
        void LED_Shine()
        {
            if (H8tekitou.P5DDR == true && H8tekitou.P5DR == true) {
                // 光らせる
            }
        }
    }

    // 作成したソースから変換して(mainをSourceに)埋め込む
    class H8tekitou
    {
        public static bool P5DDR;
        public static bool P4DDR;

        public static bool P5DR;
        public static bool P4DR;



        // cのmainかんすうを変換した関数的な何か
        // 別スレッド(?)で実行
        static void Source()
        {

            // 色々省略

            P5DDR = true;
            P4DDR = true;

            while (true) {
                if (P4DR == true) {
                    P5DR = true;
                }
            }
        }
    }
}
*/
