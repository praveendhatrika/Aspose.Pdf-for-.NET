'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Devices

Namespace VisualBasic.AsposePdf.Images
    Public Class PageToEMF
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_Images()

            'open document
            Dim pdfDocument As New Document(dataDir & "PageToEMF.pdf")


            Using imageStream As New FileStream(dataDir & "image.emf", FileMode.Create)
                'create Resolution object
                Dim resolution As New Resolution(300)
                'create EMF device with specified attributes
                'Width, Height, Resolution
                Dim emfDevice As New EmfDevice(500, 700, resolution)

                'convert a particular page and save the image to stream
                emfDevice.Process(pdfDocument.Pages(1), imageStream)

                'close stream
                imageStream.Close()
            End Using



        End Sub
    End Class
End Namespace