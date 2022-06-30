namespace Image2PDF
{
    public enum PageSize
    {
        ImageSize = 0,
        A0 = 1,
        A1 = 2,
        A2 = 3,
        A3 = 4,
        A4 = 5,
        A5 = 6,
        A6 = 7,
        A7 = 8,
        A8 = 9,
        A9 = 10,
        A10 = 11,
        B0 = 12,
        B1 = 13,
        B2 = 14,
        B3 = 15,
        B4 = 16,
        B5 = 17,
        B6 = 18,
        B7 = 19,
        B8 = 20,
        B9 = 21,
        B10 = 22,
        Legal = 23,
        Letter = 24,
        Executive = 25,
        Ledger = 26,
        Tabloid = 27
    }

    public static class PageSizeExtension
    {
        public static iText.Kernel.Geom.Rectangle? PdfSize(this PageSize size)
        {
            switch (size)
            {
                case PageSize.A0:
                    return iText.Kernel.Geom.PageSize.A0;

                case PageSize.A1:
                    return iText.Kernel.Geom.PageSize.A1;

                case PageSize.A2:
                    return iText.Kernel.Geom.PageSize.A2;

                case PageSize.A3:
                    return iText.Kernel.Geom.PageSize.A3;

                case PageSize.A4:
                    return iText.Kernel.Geom.PageSize.A4;

                case PageSize.A5:
                    return iText.Kernel.Geom.PageSize.A5;

                case PageSize.A6:
                    return iText.Kernel.Geom.PageSize.A6;

                case PageSize.A7:
                    return iText.Kernel.Geom.PageSize.A7;

                case PageSize.A8:
                    return iText.Kernel.Geom.PageSize.A8;

                case PageSize.A9:
                    return iText.Kernel.Geom.PageSize.A9;

                case PageSize.A10:
                    return iText.Kernel.Geom.PageSize.A10;

                case PageSize.B0:
                    return iText.Kernel.Geom.PageSize.B0;

                case PageSize.B1:
                    return iText.Kernel.Geom.PageSize.B1;

                case PageSize.B2:
                    return iText.Kernel.Geom.PageSize.B2;

                case PageSize.B3:
                    return iText.Kernel.Geom.PageSize.B3;

                case PageSize.B4:
                    return iText.Kernel.Geom.PageSize.B4;

                case PageSize.B5:
                    return iText.Kernel.Geom.PageSize.B5;

                case PageSize.B6:
                    return iText.Kernel.Geom.PageSize.B6;

                case PageSize.B7:
                    return iText.Kernel.Geom.PageSize.B7;

                case PageSize.B8:
                    return iText.Kernel.Geom.PageSize.B8;

                case PageSize.B9:
                    return iText.Kernel.Geom.PageSize.B9;

                case PageSize.B10:
                    return iText.Kernel.Geom.PageSize.B10;

                case PageSize.Letter:
                    return iText.Kernel.Geom.PageSize.LETTER;

                case PageSize.Legal:
                    return iText.Kernel.Geom.PageSize.LEGAL;

                case PageSize.Executive:
                    return iText.Kernel.Geom.PageSize.EXECUTIVE;

                case PageSize.Ledger:
                    return iText.Kernel.Geom.PageSize.LEDGER;

                case PageSize.Tabloid:
                    return iText.Kernel.Geom.PageSize.TABLOID;

                case PageSize.ImageSize:
                default:
                    return null;
            }
        }

        public static PageSize SizeOf(iText.Kernel.Geom.Rectangle size)
        {
            if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.A0))
            {
                return PageSize.A0;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.A1))
            {
                return PageSize.A1;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.A2))
            {
                return PageSize.A2;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.A3))
            {
                return PageSize.A3;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.A4))
            {
                return PageSize.A4;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.A5))
            {
                return PageSize.A5;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.A6))
            {
                return PageSize.A6;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.A7))
            {
                return PageSize.A7;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.A8))
            {
                return PageSize.A8;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.A9))
            {
                return PageSize.A9;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.A10))
            {
                return PageSize.A10;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.B0))
            {
                return PageSize.B0;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.B1))
            {
                return PageSize.B1;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.B2))
            {
                return PageSize.B2;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.B3))
            {
                return PageSize.B3;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.B4))
            {
                return PageSize.B4;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.B5))
            {
                return PageSize.B5;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.B6))
            {
                return PageSize.B6;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.B7))
            {
                return PageSize.B7;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.B8))
            {
                return PageSize.B8;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.B9))
            {
                return PageSize.B9;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.B10))
            {
                return PageSize.B10;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.LEGAL))
            {
                return PageSize.Legal;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.LETTER))
            {
                return PageSize.Letter;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.TABLOID))
            {
                return PageSize.Tabloid;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.LEDGER))
            {
                return PageSize.Ledger;
            }
            else if (size.EqualsWithEpsilon(iText.Kernel.Geom.PageSize.EXECUTIVE))
            {
                return PageSize.Executive;
            }

            return PageSize.ImageSize;
        }
    }
}
