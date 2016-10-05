Imports System.Xml
Module Module1
  Sub Main()
    Dim filename As String = "C:\\books.xml"
    Dim xmlDoc As XmlDocument = New XmlDocument()
    xmlDoc.Load(filename)

    Dim root As XmlNode = xmlDoc.DocumentElement
    Console.WriteLine("XML Document Fragment")
    Console.WriteLine("=====================")

    xmlDoc.Save(Console.Out)
    Console.WriteLine()
    Console.WriteLine("---------------------")
    Console.WriteLine("XML Document Fragment After RemoveAll")
    Console.WriteLine("=====================")
    'Remove all attribute and child nodes.
    root.RemoveAll()
    ' Display the contents on the console after
    ' removing elements and attributes
    xmlDoc.Save(Console.Out)



  End Sub
End Module
