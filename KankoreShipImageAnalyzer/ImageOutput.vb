Imports System.IO
Imports DDW.Swf

Module ImageOutput
    <Runtime.CompilerServices.Extension>
    Public Function ToBitmap(tag As DefineBitsTag) As Bitmap
        Dim png As Bitmap = Nothing
        If tag.TagType = TagType.DefineBitsJPEG2 OrElse tag.TagType = TagType.DefineBitsJPEG3 Then
            If tag.HasAlphaData = False Then
                Dim mem = New MemoryStream(tag.JpegData)
                'mem.Close();
                png = New Bitmap(mem)
            Else
                Dim mem = New MemoryStream(tag.JpegData)
                Dim bmp As New Bitmap(mem)
                png = New Bitmap(bmp.Width, bmp.Height)
                Dim g As Graphics = Graphics.FromImage(png)
                g.DrawImage(bmp, 0, 0)
                Dim alpha = SwfReader.Decompress(tag.CompressedAlphaData, CUInt(bmp.Width * bmp.Height))
                Dim j As Integer = 0
                For y As Integer = 0 To bmp.Height - 1
                    For x As Integer = 0 To bmp.Width - 1
                        Dim a As Integer = alpha(j)
                        Dim c = bmp.GetPixel(x, y)
                        Dim col = Color.FromArgb(a, c)
                        png.SetPixel(x, y, col)
                        j += 1
                    Next
                Next
            End If
        ElseIf tag.TagType = TagType.DefineBits Then
            Dim size As Integer = tag.JpegData.Count() + 4
            Dim buf As Byte() = New Byte(size - 1) {}

            For i As Integer = 0 To tag.JpegData.Count() - 1
                buf(i + 2) = tag.JpegData(i)
            Next
            buf(0) = &HFF
            buf(1) = &HD8
            buf(2 + tag.JpegData.Count()) = &HFF
            buf(2 + tag.JpegData.Count() + 1) = &HD9
            Dim mem = New MemoryStream(buf)
            ' mem.Close();
            png = New Bitmap(mem)
        End If
        Return png
    End Function

End Module
