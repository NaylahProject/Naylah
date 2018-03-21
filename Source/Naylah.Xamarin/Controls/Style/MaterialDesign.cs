﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Naylah.Xamarin.Controls.Style
{
    public class MaterialDesign
    {
        public class ColorScheme
        {
            /// <summary>
            /// The most widely used across all screens and components.
            /// In material design palette, it's the "500" variation.
            /// Has some variations in dark and light usages
            /// </summary>
            public string PrimaryColor { get; set; }

            public string PrimaryColorDark { get; set; }

            public string PrimaryColorLight { get; set; }

            /// <summary>
            /// This color may idicate a relatedAction or information.
            /// </summary>
            public string SecondaryColor { get; set; }

            public string SecondaryColorDark { get; set; }

            public string SecondaryColorLight { get; set; }

            /// <summary>
            /// This normally is the secondary color it self. It's used to actions like action button
            /// and interactive elements.
            /// Text fields, cursors, text selection, progress bar,
            /// selection controls, buttons, sliders, links
            /// </summary>
            public string AccentColor { get; set; }



            public string BackgroundColorSystem { get; set; }

            public string BackgroundColorAppBar { get; set; }

            public string BackgroundColorPage { get; set; }

            public string BackgroundColorModal { get; set; }



            public string PrimaryTextColor { get; set; }

            public string SecondaryTextColor { get; set; }

            public string DisabledTextColor { get; set; }

            public string DividerColor { get; set; }

            public string TextColorOfPrimaryColor { get; set; }

            public string TextColorOfAccentColor { get; set; }



            public string ActiveIconColor { get; set; }

            public string InactiveIconColor { get; set; }

            public virtual void CopyFrom(ColorScheme colorScheme)
            {
                PrimaryColor = colorScheme.PrimaryColor;
                PrimaryColorDark = colorScheme.PrimaryColorDark;
                PrimaryColorLight = colorScheme.PrimaryColorLight;

                SecondaryColor = colorScheme.SecondaryColor;
                SecondaryColorDark = colorScheme.SecondaryColorDark;
                SecondaryColorLight = colorScheme.SecondaryColorLight;

                AccentColor = colorScheme.AccentColor;

                BackgroundColorSystem = colorScheme.BackgroundColorSystem;
                BackgroundColorAppBar = colorScheme.BackgroundColorAppBar;
                BackgroundColorPage = colorScheme.BackgroundColorPage;
                BackgroundColorModal = colorScheme.BackgroundColorModal;


                PrimaryTextColor = colorScheme.PrimaryTextColor;
                SecondaryTextColor = colorScheme.SecondaryTextColor;
                DisabledTextColor = colorScheme.DisabledTextColor;
                DividerColor = colorScheme.DividerColor;
                TextColorOfPrimaryColor = colorScheme.TextColorOfPrimaryColor;
                TextColorOfAccentColor = colorScheme.TextColorOfAccentColor;

                ActiveIconColor = colorScheme.ActiveIconColor;
                InactiveIconColor = colorScheme.InactiveIconColor;

            }
        }

        public class Colors
        {
            public const string Black = "#000000";
            public const string White = "#FFFFFF";

            public struct Red
            {
                public const string Red50 = "#FFEBEE";
                public const string Red100 = "#FFCDD2";
                public const string Red200 = "#EF9A9A";
                public const string Red300 = "#E57373";
                public const string Red400 = "#EF5350";
                public const string Red500 = "#F44336";
                public const string Red600 = "#E53935";
                public const string Red700 = "#D32F2F";
                public const string Red800 = "#C62828";
                public const string Red900 = "B71C1C";

                public const string RedA100 = "#FF8A80";
                public const string RedA200 = "#FF5252";
                public const string RedA400 = "#FF1744";
                public const string RedA700 = "#D50000";
            }

            public struct Pink
            {
                public const string Pink50 = "#FCE4EC";
                public const string Pink100 = "#F8BBD0";
                public const string Pink200 = "#F48FB1";
                public const string Pink300 = "#F06292";
                public const string Pink400 = "#EC407A";
                public const string Pink500 = "#E91E63";
                public const string Pink600 = "#D81B60";
                public const string Pink700 = "#C2185B";
                public const string Pink800 = "#AD1457";
                public const string Pink900 = "#880E4F";

                public const string PinkA100 = "#FF80AB";
                public const string PinkA200 = "#FF4081";
                public const string PinkA400 = "#F50057";
                public const string PinkA700 = "#C51162";
            }

            public struct Purple
            {
                public const string Purple50 = "#F3E5F5";
                public const string Purple100 = "#E1BEE7";
                public const string Purple200 = "#CE93D8";
                public const string Purple300 = "#BA68C8";
                public const string Purple400 = "#AB47BC";
                public const string Purple500 = "#9C27B0";
                public const string Purple600 = "#8E24AA";
                public const string Purple700 = "#7B1FA2";
                public const string Purple800 = "#6A1B9A";
                public const string Purple900 = "#4A148C";

                public const string PurpleA100 = "#EA80FC";
                public const string PurpleA200 = "#E040FB";
                public const string PurpleA400 = "#D500F9";
                public const string PurpleA700 = "#AA00FF";
            }

            public struct DeepPurple
            {
                public const string DeepPurple50 = "#EDE7F6";
                public const string DeepPurple100 = "#D1C4E9";
                public const string DeepPurple200 = "#B39DDB";
                public const string DeepPurple300 = "#9575CD";
                public const string DeepPurple400 = "#7E57C2";
                public const string DeepPurple500 = "#673AB7";
                public const string DeepPurple600 = "#5E35B1";
                public const string DeepPurple700 = "#512DA8";
                public const string DeepPurple800 = "#4527A0";
                public const string DeepPurple900 = "#311B92";

                public const string DeepPurpleA100 = "#B388FF";
                public const string DeepPurpleA200 = "#7C4DFF";
                public const string DeepPurpleA400 = "#651FFF";
                public const string DeepPurpleA700 = "#6200EA";
            }

            public struct Indigo
            {
                public const string Indigo50 = "#E8EAF6";
                public const string Indigo100 = "#C5CAE9";
                public const string Indigo200 = "#9FA8DA";
                public const string Indigo300 = "#7986CB";
                public const string Indigo400 = "#5C6BC0";
                public const string Indigo500 = "#3F51B5";
                public const string Indigo600 = "#3949AB";
                public const string Indigo700 = "#303F9F";
                public const string Indigo800 = "#283593";
                public const string Indigo900 = "#1A237E";

                public const string IndigoA100 = "#8C9EFF";
                public const string IndigoA200 = "#536DFE";
                public const string IndigoA400 = "#3D5AFE";
                public const string IndigoA700 = "#304FFE";
            }

            public struct Blue
            {
                public const string Blue50 = "#E3F2FD";
                public const string Blue100 = "#BBDEFB";
                public const string Blue200 = "#90CAF9";
                public const string Blue300 = "#64B5F6";
                public const string Blue400 = "#42A5F5";
                public const string Blue500 = "#2196F3";
                public const string Blue600 = "#1E88E5";
                public const string Blue700 = "#1976D2";
                public const string Blue800 = "#1565C0";
                public const string Blue900 = "#0D47A1";

                public const string BlueA100 = "#82B1FF";
                public const string BlueA200 = "#448AFF";
                public const string BlueA400 = "#2979FF";
                public const string BlueA700 = "#2962FF";
            }

            public struct LightBlue
            {
                public const string LightBlue50 = "#E1F5FE";
                public const string LightBlue100 = "#B3E5FC";
                public const string LightBlue200 = "#81D4FA";
                public const string LightBlue300 = "#4FC3F7";
                public const string LightBlue400 = "#29B6F6";
                public const string LightBlue500 = "#03A9F4";
                public const string LightBlue600 = "#039BE5";
                public const string LightBlue700 = "#0288D1";
                public const string LightBlue800 = "#0277BD";
                public const string LightBlue900 = "#01579B";

                public const string LightBlueA100 = "#80D8FF";
                public const string LightBlueA200 = "#40C4FF";
                public const string LightBlueA400 = "#00B0FF";
                public const string LightBlueA700 = "#0091EA";
            }

            public struct Cyan
            {
                public const string Cyan50 = "#E0F7FA";
                public const string Cyan100 = "#B2EBF2";
                public const string Cyan200 = "#80DEEA";
                public const string Cyan300 = "#4DD0E1";
                public const string Cyan400 = "#26C6DA";
                public const string Cyan500 = "#00BCD4";
                public const string Cyan600 = "#00ACC1";
                public const string Cyan700 = "#0097A7";
                public const string Cyan800 = "#00838F";
                public const string Cyan900 = "#006064";

                public const string CyanA100 = "#84FFFF";
                public const string CyanA200 = "#18FFFF";
                public const string CyanA400 = "#00E5FF";
                public const string CyanA700 = "#00B8D4";
            }

            public struct Teal
            {
                public const string Teal50 = "#E0F2F1";
                public const string Teal100 = "#B2DFDB";
                public const string Teal200 = "#80CBC4";
                public const string Teal300 = "#4DB6AC";
                public const string Teal400 = "#26A69A";
                public const string Teal500 = "#009688";
                public const string Teal600 = "#00897B";
                public const string Teal700 = "#00796B";
                public const string Teal800 = "#00695C";
                public const string Teal900 = "#004D40";

                public const string TealA100 = "#A7FFEB";
                public const string TealA200 = "#64FFDA";
                public const string TealA400 = "#1DE9B6";
                public const string TealA700 = "#00BFA5";
            }

            public struct Green
            {
                public const string Green50 = "#E8F5E9";
                public const string Green100 = "#C8E6C9";
                public const string Green200 = "#A5D6A7";
                public const string Green300 = "#81C784";
                public const string Green400 = "#66BB6A";
                public const string Green500 = "#4CAF50";
                public const string Green600 = "#43A047";
                public const string Green700 = "#388E3C";
                public const string Green800 = "#2E7D32";
                public const string Green900 = "#1B5E20";

                public const string GreenA100 = "#B9F6CA";
                public const string GreenA200 = "#69F0AE";
                public const string GreenA400 = "#00E676";
                public const string GreenA700 = "#00C853";
            }

            public struct LightGreen
            {
                public const string LightGreen50 = "#F1F8E9";
                public const string LightGreen100 = "#DCEDC8";
                public const string LightGreen200 = "#C5E1A5";
                public const string LightGreen300 = "#AED581";
                public const string LightGreen400 = "#9CCC65";
                public const string LightGreen500 = "#8BC34A";
                public const string LightGreen600 = "#7CB342";
                public const string LightGreen700 = "#689F38";
                public const string LightGreen800 = "#558B2F";
                public const string LightGreen900 = "#33691E";

                public const string LightGreenA100 = "#CCFF90";
                public const string LightGreenA200 = "#B2FF59";
                public const string LightGreenA400 = "#76FF03";
                public const string LightGreenA700 = "#64DD17";
            }

            public struct Lime
            {
                public const string Lime50 = "#F9FBE7";
                public const string Lime100 = "#F0F4C3";
                public const string Lime200 = "#E6EE9C";
                public const string Lime300 = "#DCE775";
                public const string Lime400 = "#D4E157";
                public const string Lime500 = "#CDDC39";
                public const string Lime600 = "#C0CA33";
                public const string Lime700 = "#AFB42B";
                public const string Lime800 = "#9E9D24";
                public const string Lime900 = "#827717";

                public const string LimeA100 = "#F4FF81";
                public const string LimeA200 = "#EEFF41";
                public const string LimeA400 = "#C6FF00";
                public const string LimeA700 = "#AEEA00";
            }

            public struct Yellow
            {
                public const string Yellow50 = "#FFFDE7";
                public const string Yellow100 = "#FFF9C4";
                public const string Yellow200 = "#FFF59D";
                public const string Yellow300 = "#FFF176";
                public const string Yellow400 = "#FFEE58";
                public const string Yellow500 = "#FFEB3B";
                public const string Yellow600 = "#FDD835";
                public const string Yellow700 = "#FBC02D";
                public const string Yellow800 = "#F9A825";
                public const string Yellow900 = "#F57F17";

                public const string YellowA100 = "#FFFF8D";
                public const string YellowA200 = "#FFFF00";
                public const string YellowA400 = "#FFEA00";
                public const string YellowA700 = "#FFD600";
            }

            public struct Amber
            {
                public const string Amber50 = "#FFF8E1";
                public const string Amber100 = "#FFECB3";
                public const string Amber200 = "#FFE082";
                public const string Amber300 = "#FFD54F";
                public const string Amber400 = "#FFCA28";
                public const string Amber500 = "#FFC107";
                public const string Amber600 = "#FFB300";
                public const string Amber700 = "#FFA000";
                public const string Amber800 = "#FF8F00";
                public const string Amber900 = "#FF6F00";

                public const string AmberA100 = "#FFE57F";
                public const string AmberA200 = "#FFD740";
                public const string AmberA400 = "#FFC400";
                public const string AmberA700 = "#FFAB00";
            }

            public struct Orange
            {
                public const string Orange50 = "#FFF3E0";
                public const string Orange100 = "#FFE0B2";
                public const string Orange200 = "#FFCC80";
                public const string Orange300 = "#FFB74D";
                public const string Orange400 = "#FFA726";
                public const string Orange500 = "#FF9800";
                public const string Orange600 = "#FB8C00";
                public const string Orange700 = "#F57C00";
                public const string Orange800 = "#EF6C00";
                public const string Orange900 = "#E65100";

                public const string OrangeA100 = "#FFD180";
                public const string OrangeA200 = "#FFAB40";
                public const string OrangeA400 = "#FF9100";
                public const string OrangeA700 = "#FF6D00";
            }

            public struct DeepOrange
            {
                public const string DeepOrange50 = "#FBE9E7";
                public const string DeepOrange100 = "#FFCCBC";
                public const string DeepOrange200 = "#FFAB91";
                public const string DeepOrange300 = "#FF8A65";
                public const string DeepOrange400 = "#FF7043";
                public const string DeepOrange500 = "#FF5722";
                public const string DeepOrange600 = "#F4511E";
                public const string DeepOrange700 = "#E64A19";
                public const string DeepOrange800 = "#D84315";
                public const string DeepOrange900 = "#BF360C";

                public const string DeepOrangeA100 = "#FF9E80";
                public const string DeepOrangeA200 = "#FF6E40";
                public const string DeepOrangeA400 = "#FF3D00";
                public const string DeepOrangeA700 = "#DD2C00";
            }

            public struct Brown
            {
                public const string Brown50 = "#EFEBE9";
                public const string Brown100 = "#D7CCC8";
                public const string Brown200 = "#BCAAA4";
                public const string Brown300 = "#A1887F";
                public const string Brown400 = "#8D6E63";
                public const string Brown500 = "#795548";
                public const string Brown600 = "#6D4C41";
                public const string Brown700 = "#5D4037";
                public const string Brown800 = "#4E342E";
                public const string Brown900 = "#3E2723";

            }

            public struct Grey
            {
                public const string Grey50 = "#FAFAFA";
                public const string Grey100 = "#F5F5F5";
                public const string Grey200 = "#EEEEEE";
                public const string Grey300 = "#E0E0E0";
                public const string Grey400 = "#BDBDBD";
                public const string Grey500 = "#9E9E9E";
                public const string Grey600 = "#757575";
                public const string Grey700 = "#616161";
                public const string Grey800 = "#424242";
                public const string Grey900 = "#212121";

            }

            public struct BlueGrey
            {
                public const string BlueGrey50 = "#ECEFF1";
                public const string BlueGrey100 = "#CFD8DC";
                public const string BlueGrey200 = "#B0BEC5";
                public const string BlueGrey300 = "#90A4AE";
                public const string BlueGrey400 = "#78909C";
                public const string BlueGrey500 = "#607D8B";
                public const string BlueGrey600 = "#546E7A";
                public const string BlueGrey700 = "#455A64";
                public const string BlueGrey800 = "#37474F";
                public const string BlueGrey900 = "#263238";

            }
        }
    }

    public static class MaterialDesignExtensions
    {
        public static bool IsValidHexColor(this string colorHex)
        {

            try
            {
                if (string.IsNullOrEmpty(colorHex))
                {
                    return false;
                }

                colorHex = colorHex.Replace("#", "");

                if (!((colorHex.Length == 6) || (colorHex.Length == 8)))
                {
                    return false;
                }

                int num = Int32.Parse(colorHex, System.Globalization.NumberStyles.HexNumber);

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }


    }
}
