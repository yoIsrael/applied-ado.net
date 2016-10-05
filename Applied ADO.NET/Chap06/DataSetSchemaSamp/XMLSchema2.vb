﻿'------------------------------------------------------------------------------
' <autogenerated>
'     This code was generated by a tool.
'     Runtime Version: 1.0.3705.209
'
'     Changes to this file may cause incorrect behavior and will be lost if 
'     the code is regenerated.
' </autogenerated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Data
Imports System.Runtime.Serialization
Imports System.Xml


<Serializable(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Diagnostics.DebuggerStepThrough(),  _
 System.ComponentModel.ToolboxItem(true)>  _
Public Class Document
    Inherits DataSet
    
    Private tableEmployees As EmployeesDataTable
    
    Public Sub New()
        MyBase.New
        Me.InitClass
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
        MyBase.New
        Dim strSchema As String = CType(info.GetValue("XmlSchema", GetType(System.String)),String)
        If (Not (strSchema) Is Nothing) Then
            Dim ds As DataSet = New DataSet
            ds.ReadXmlSchema(New XmlTextReader(New System.IO.StringReader(strSchema)))
            If (Not (ds.Tables("Employees")) Is Nothing) Then
                Me.Tables.Add(New EmployeesDataTable(ds.Tables("Employees")))
            End If
            Me.DataSetName = ds.DataSetName
            Me.Prefix = ds.Prefix
            Me.Namespace = ds.Namespace
            Me.Locale = ds.Locale
            Me.CaseSensitive = ds.CaseSensitive
            Me.EnforceConstraints = ds.EnforceConstraints
            Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
            Me.InitVars
        Else
            Me.InitClass
        End If
        Me.GetSerializationData(info, context)
        Dim schemaChangedHandler As System.ComponentModel.CollectionChangeEventHandler = AddressOf Me.SchemaChanged
        AddHandler Me.Tables.CollectionChanged, schemaChangedHandler
        AddHandler Me.Relations.CollectionChanged, schemaChangedHandler
    End Sub
    
    <System.ComponentModel.Browsable(false),  _
     System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)>  _
    Public ReadOnly Property Employees As EmployeesDataTable
        Get
            Return Me.tableEmployees
        End Get
    End Property
    
    Public Overrides Function Clone() As DataSet
        Dim cln As Document = CType(MyBase.Clone,Document)
        cln.InitVars
        Return cln
    End Function
    
    Protected Overrides Function ShouldSerializeTables() As Boolean
        Return false
    End Function
    
    Protected Overrides Function ShouldSerializeRelations() As Boolean
        Return false
    End Function
    
    Protected Overrides Sub ReadXmlSerializable(ByVal reader As XmlReader)
        Me.Reset
        Dim ds As DataSet = New DataSet
        ds.ReadXml(reader)
        If (Not (ds.Tables("Employees")) Is Nothing) Then
            Me.Tables.Add(New EmployeesDataTable(ds.Tables("Employees")))
        End If
        Me.DataSetName = ds.DataSetName
        Me.Prefix = ds.Prefix
        Me.Namespace = ds.Namespace
        Me.Locale = ds.Locale
        Me.CaseSensitive = ds.CaseSensitive
        Me.EnforceConstraints = ds.EnforceConstraints
        Me.Merge(ds, false, System.Data.MissingSchemaAction.Add)
        Me.InitVars
    End Sub
    
    Protected Overrides Function GetSchemaSerializable() As System.Xml.Schema.XmlSchema
        Dim stream As System.IO.MemoryStream = New System.IO.MemoryStream
        Me.WriteXmlSchema(New XmlTextWriter(stream, Nothing))
        stream.Position = 0
        Return System.Xml.Schema.XmlSchema.Read(New XmlTextReader(stream), Nothing)
    End Function
    
    Friend Sub InitVars()
        Me.tableEmployees = CType(Me.Tables("Employees"),EmployeesDataTable)
        If (Not (Me.tableEmployees) Is Nothing) Then
            Me.tableEmployees.InitVars
        End If
    End Sub
    
    Private Sub InitClass()
        Me.DataSetName = "Document"
        Me.Prefix = ""
        Me.Namespace = "http://tempuri.org/XMLSchema2.xsd"
        Me.Locale = New System.Globalization.CultureInfo("en-US")
        Me.CaseSensitive = false
        Me.EnforceConstraints = true
        Me.tableEmployees = New EmployeesDataTable
        Me.Tables.Add(Me.tableEmployees)
    End Sub
    
    Private Function ShouldSerializeEmployees() As Boolean
        Return false
    End Function
    
    Private Sub SchemaChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If (e.Action = System.ComponentModel.CollectionChangeAction.Remove) Then
            Me.InitVars
        End If
    End Sub
    
    Public Delegate Sub EmployeesRowChangeEventHandler(ByVal sender As Object, ByVal e As EmployeesRowChangeEvent)
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class EmployeesDataTable
        Inherits DataTable
        Implements System.Collections.IEnumerable
        
        Private columnEmployeeID As DataColumn
        
        Private columnLastName As DataColumn
        
        Private columnFirstName As DataColumn
        
        Private columnTitle As DataColumn
        
        Private columnTitleOfCourtesy As DataColumn
        
        Private columnBirthDate As DataColumn
        
        Private columnHireDate As DataColumn
        
        Private columnAddress As DataColumn
        
        Private columnCity As DataColumn
        
        Private column_Region As DataColumn
        
        Private columnPostalCode As DataColumn
        
        Private columnCountry As DataColumn
        
        Private columnHomePhone As DataColumn
        
        Private columnExtension As DataColumn
        
        Private columnPhoto As DataColumn
        
        Private columnNotes As DataColumn
        
        Private columnReportsTo As DataColumn
        
        Private columnPhotoPath As DataColumn
        
        Friend Sub New()
            MyBase.New("Employees")
            Me.InitClass
        End Sub
        
        Friend Sub New(ByVal table As DataTable)
            MyBase.New(table.TableName)
            If (table.CaseSensitive <> table.DataSet.CaseSensitive) Then
                Me.CaseSensitive = table.CaseSensitive
            End If
            If (table.Locale.ToString <> table.DataSet.Locale.ToString) Then
                Me.Locale = table.Locale
            End If
            If (table.Namespace <> table.DataSet.Namespace) Then
                Me.Namespace = table.Namespace
            End If
            Me.Prefix = table.Prefix
            Me.MinimumCapacity = table.MinimumCapacity
            Me.DisplayExpression = table.DisplayExpression
        End Sub
        
        <System.ComponentModel.Browsable(false)>  _
        Public ReadOnly Property Count As Integer
            Get
                Return Me.Rows.Count
            End Get
        End Property
        
        Friend ReadOnly Property EmployeeIDColumn As DataColumn
            Get
                Return Me.columnEmployeeID
            End Get
        End Property
        
        Friend ReadOnly Property LastNameColumn As DataColumn
            Get
                Return Me.columnLastName
            End Get
        End Property
        
        Friend ReadOnly Property FirstNameColumn As DataColumn
            Get
                Return Me.columnFirstName
            End Get
        End Property
        
        Friend ReadOnly Property TitleColumn As DataColumn
            Get
                Return Me.columnTitle
            End Get
        End Property
        
        Friend ReadOnly Property TitleOfCourtesyColumn As DataColumn
            Get
                Return Me.columnTitleOfCourtesy
            End Get
        End Property
        
        Friend ReadOnly Property BirthDateColumn As DataColumn
            Get
                Return Me.columnBirthDate
            End Get
        End Property
        
        Friend ReadOnly Property HireDateColumn As DataColumn
            Get
                Return Me.columnHireDate
            End Get
        End Property
        
        Friend ReadOnly Property AddressColumn As DataColumn
            Get
                Return Me.columnAddress
            End Get
        End Property
        
        Friend ReadOnly Property CityColumn As DataColumn
            Get
                Return Me.columnCity
            End Get
        End Property
        
        Friend ReadOnly Property _RegionColumn As DataColumn
            Get
                Return Me.column_Region
            End Get
        End Property
        
        Friend ReadOnly Property PostalCodeColumn As DataColumn
            Get
                Return Me.columnPostalCode
            End Get
        End Property
        
        Friend ReadOnly Property CountryColumn As DataColumn
            Get
                Return Me.columnCountry
            End Get
        End Property
        
        Friend ReadOnly Property HomePhoneColumn As DataColumn
            Get
                Return Me.columnHomePhone
            End Get
        End Property
        
        Friend ReadOnly Property ExtensionColumn As DataColumn
            Get
                Return Me.columnExtension
            End Get
        End Property
        
        Friend ReadOnly Property PhotoColumn As DataColumn
            Get
                Return Me.columnPhoto
            End Get
        End Property
        
        Friend ReadOnly Property NotesColumn As DataColumn
            Get
                Return Me.columnNotes
            End Get
        End Property
        
        Friend ReadOnly Property ReportsToColumn As DataColumn
            Get
                Return Me.columnReportsTo
            End Get
        End Property
        
        Friend ReadOnly Property PhotoPathColumn As DataColumn
            Get
                Return Me.columnPhotoPath
            End Get
        End Property
        
        Public Default ReadOnly Property Item(ByVal index As Integer) As EmployeesRow
            Get
                Return CType(Me.Rows(index),EmployeesRow)
            End Get
        End Property
        
        Public Event EmployeesRowChanged As EmployeesRowChangeEventHandler
        
        Public Event EmployeesRowChanging As EmployeesRowChangeEventHandler
        
        Public Event EmployeesRowDeleted As EmployeesRowChangeEventHandler
        
        Public Event EmployeesRowDeleting As EmployeesRowChangeEventHandler
        
        Public Overloads Sub AddEmployeesRow(ByVal row As EmployeesRow)
            Me.Rows.Add(row)
        End Sub
        
        Public Overloads Function AddEmployeesRow( _
                    ByVal LastName As String,  _
                    ByVal FirstName As String,  _
                    ByVal Title As String,  _
                    ByVal TitleOfCourtesy As String,  _
                    ByVal BirthDate As Date,  _
                    ByVal HireDate As Date,  _
                    ByVal Address As String,  _
                    ByVal City As String,  _
                    ByVal _Region As String,  _
                    ByVal PostalCode As String,  _
                    ByVal Country As String,  _
                    ByVal HomePhone As String,  _
                    ByVal Extension As String,  _
                    ByVal Photo() As Byte,  _
                    ByVal Notes As String,  _
                    ByVal ReportsTo As Integer,  _
                    ByVal PhotoPath As String) As EmployeesRow
            Dim rowEmployeesRow As EmployeesRow = CType(Me.NewRow,EmployeesRow)
            rowEmployeesRow.ItemArray = New Object() {Nothing, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, _Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath}
            Me.Rows.Add(rowEmployeesRow)
            Return rowEmployeesRow
        End Function
        
        Public Function FindByEmployeeID(ByVal EmployeeID As Integer) As EmployeesRow
            Return CType(Me.Rows.Find(New Object() {EmployeeID}),EmployeesRow)
        End Function
        
        Public Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
            Return Me.Rows.GetEnumerator
        End Function
        
        Public Overrides Function Clone() As DataTable
            Dim cln As EmployeesDataTable = CType(MyBase.Clone,EmployeesDataTable)
            cln.InitVars
            Return cln
        End Function
        
        Protected Overrides Function CreateInstance() As DataTable
            Return New EmployeesDataTable
        End Function
        
        Friend Sub InitVars()
            Me.columnEmployeeID = Me.Columns("EmployeeID")
            Me.columnLastName = Me.Columns("LastName")
            Me.columnFirstName = Me.Columns("FirstName")
            Me.columnTitle = Me.Columns("Title")
            Me.columnTitleOfCourtesy = Me.Columns("TitleOfCourtesy")
            Me.columnBirthDate = Me.Columns("BirthDate")
            Me.columnHireDate = Me.Columns("HireDate")
            Me.columnAddress = Me.Columns("Address")
            Me.columnCity = Me.Columns("City")
            Me.column_Region = Me.Columns("Region")
            Me.columnPostalCode = Me.Columns("PostalCode")
            Me.columnCountry = Me.Columns("Country")
            Me.columnHomePhone = Me.Columns("HomePhone")
            Me.columnExtension = Me.Columns("Extension")
            Me.columnPhoto = Me.Columns("Photo")
            Me.columnNotes = Me.Columns("Notes")
            Me.columnReportsTo = Me.Columns("ReportsTo")
            Me.columnPhotoPath = Me.Columns("PhotoPath")
        End Sub
        
        Private Sub InitClass()
            Me.columnEmployeeID = New DataColumn("EmployeeID", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnEmployeeID)
            Me.columnLastName = New DataColumn("LastName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnLastName)
            Me.columnFirstName = New DataColumn("FirstName", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnFirstName)
            Me.columnTitle = New DataColumn("Title", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTitle)
            Me.columnTitleOfCourtesy = New DataColumn("TitleOfCourtesy", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnTitleOfCourtesy)
            Me.columnBirthDate = New DataColumn("BirthDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnBirthDate)
            Me.columnHireDate = New DataColumn("HireDate", GetType(System.DateTime), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnHireDate)
            Me.columnAddress = New DataColumn("Address", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnAddress)
            Me.columnCity = New DataColumn("City", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCity)
            Me.column_Region = New DataColumn("Region", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.column_Region)
            Me.columnPostalCode = New DataColumn("PostalCode", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPostalCode)
            Me.columnCountry = New DataColumn("Country", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnCountry)
            Me.columnHomePhone = New DataColumn("HomePhone", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnHomePhone)
            Me.columnExtension = New DataColumn("Extension", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnExtension)
            Me.columnPhoto = New DataColumn("Photo", GetType(System.Byte()), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhoto)
            Me.columnNotes = New DataColumn("Notes", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnNotes)
            Me.columnReportsTo = New DataColumn("ReportsTo", GetType(System.Int32), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnReportsTo)
            Me.columnPhotoPath = New DataColumn("PhotoPath", GetType(System.String), Nothing, System.Data.MappingType.Element)
            Me.Columns.Add(Me.columnPhotoPath)
            Me.Constraints.Add(New UniqueConstraint("DocumentKey1", New DataColumn() {Me.columnEmployeeID}, true))
            Me.columnEmployeeID.AutoIncrement = true
            Me.columnEmployeeID.AllowDBNull = false
            Me.columnEmployeeID.ReadOnly = true
            Me.columnEmployeeID.Unique = true
            Me.columnLastName.AllowDBNull = false
            Me.columnFirstName.AllowDBNull = false
        End Sub
        
        Public Function NewEmployeesRow() As EmployeesRow
            Return CType(Me.NewRow,EmployeesRow)
        End Function
        
        Protected Overrides Function NewRowFromBuilder(ByVal builder As DataRowBuilder) As DataRow
            Return New EmployeesRow(builder)
        End Function
        
        Protected Overrides Function GetRowType() As System.Type
            Return GetType(EmployeesRow)
        End Function
        
        Protected Overrides Sub OnRowChanged(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanged(e)
            If (Not (Me.EmployeesRowChangedEvent) Is Nothing) Then
                RaiseEvent EmployeesRowChanged(Me, New EmployeesRowChangeEvent(CType(e.Row,EmployeesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowChanging(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowChanging(e)
            If (Not (Me.EmployeesRowChangingEvent) Is Nothing) Then
                RaiseEvent EmployeesRowChanging(Me, New EmployeesRowChangeEvent(CType(e.Row,EmployeesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleted(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleted(e)
            If (Not (Me.EmployeesRowDeletedEvent) Is Nothing) Then
                RaiseEvent EmployeesRowDeleted(Me, New EmployeesRowChangeEvent(CType(e.Row,EmployeesRow), e.Action))
            End If
        End Sub
        
        Protected Overrides Sub OnRowDeleting(ByVal e As DataRowChangeEventArgs)
            MyBase.OnRowDeleting(e)
            If (Not (Me.EmployeesRowDeletingEvent) Is Nothing) Then
                RaiseEvent EmployeesRowDeleting(Me, New EmployeesRowChangeEvent(CType(e.Row,EmployeesRow), e.Action))
            End If
        End Sub
        
        Public Sub RemoveEmployeesRow(ByVal row As EmployeesRow)
            Me.Rows.Remove(row)
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class EmployeesRow
        Inherits DataRow
        
        Private tableEmployees As EmployeesDataTable
        
        Friend Sub New(ByVal rb As DataRowBuilder)
            MyBase.New(rb)
            Me.tableEmployees = CType(Me.Table,EmployeesDataTable)
        End Sub
        
        Public Property EmployeeID As Integer
            Get
                Return CType(Me(Me.tableEmployees.EmployeeIDColumn),Integer)
            End Get
            Set
                Me(Me.tableEmployees.EmployeeIDColumn) = value
            End Set
        End Property
        
        Public Property LastName As String
            Get
                Return CType(Me(Me.tableEmployees.LastNameColumn),String)
            End Get
            Set
                Me(Me.tableEmployees.LastNameColumn) = value
            End Set
        End Property
        
        Public Property FirstName As String
            Get
                Return CType(Me(Me.tableEmployees.FirstNameColumn),String)
            End Get
            Set
                Me(Me.tableEmployees.FirstNameColumn) = value
            End Set
        End Property
        
        Public Property Title As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.TitleColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.TitleColumn) = value
            End Set
        End Property
        
        Public Property TitleOfCourtesy As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.TitleOfCourtesyColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.TitleOfCourtesyColumn) = value
            End Set
        End Property
        
        Public Property BirthDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.BirthDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.BirthDateColumn) = value
            End Set
        End Property
        
        Public Property HireDate As Date
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.HireDateColumn),Date)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.HireDateColumn) = value
            End Set
        End Property
        
        Public Property Address As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.AddressColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.AddressColumn) = value
            End Set
        End Property
        
        Public Property City As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.CityColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.CityColumn) = value
            End Set
        End Property
        
        Public Property _Region As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees._RegionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees._RegionColumn) = value
            End Set
        End Property
        
        Public Property PostalCode As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.PostalCodeColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.PostalCodeColumn) = value
            End Set
        End Property
        
        Public Property Country As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.CountryColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.CountryColumn) = value
            End Set
        End Property
        
        Public Property HomePhone As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.HomePhoneColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.HomePhoneColumn) = value
            End Set
        End Property
        
        Public Property Extension As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.ExtensionColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.ExtensionColumn) = value
            End Set
        End Property
        
        Public Property Photo As Byte()
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.PhotoColumn),Byte())
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.PhotoColumn) = value
            End Set
        End Property
        
        Public Property Notes As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.NotesColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.NotesColumn) = value
            End Set
        End Property
        
        Public Property ReportsTo As Integer
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.ReportsToColumn),Integer)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.ReportsToColumn) = value
            End Set
        End Property
        
        Public Property PhotoPath As String
            Get
                Try 
                    Return CType(Me(Me.tableEmployees.PhotoPathColumn),String)
                Catch e As InvalidCastException
                    Throw New StrongTypingException("Cannot get value because it is DBNull.", e)
                End Try
            End Get
            Set
                Me(Me.tableEmployees.PhotoPathColumn) = value
            End Set
        End Property
        
        Public Function IsTitleNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.TitleColumn)
        End Function
        
        Public Sub SetTitleNull()
            Me(Me.tableEmployees.TitleColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsTitleOfCourtesyNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.TitleOfCourtesyColumn)
        End Function
        
        Public Sub SetTitleOfCourtesyNull()
            Me(Me.tableEmployees.TitleOfCourtesyColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsBirthDateNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.BirthDateColumn)
        End Function
        
        Public Sub SetBirthDateNull()
            Me(Me.tableEmployees.BirthDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsHireDateNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.HireDateColumn)
        End Function
        
        Public Sub SetHireDateNull()
            Me(Me.tableEmployees.HireDateColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsAddressNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.AddressColumn)
        End Function
        
        Public Sub SetAddressNull()
            Me(Me.tableEmployees.AddressColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCityNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.CityColumn)
        End Function
        
        Public Sub SetCityNull()
            Me(Me.tableEmployees.CityColumn) = System.Convert.DBNull
        End Sub
        
        Public Function Is_RegionNull() As Boolean
            Return Me.IsNull(Me.tableEmployees._RegionColumn)
        End Function
        
        Public Sub Set_RegionNull()
            Me(Me.tableEmployees._RegionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPostalCodeNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.PostalCodeColumn)
        End Function
        
        Public Sub SetPostalCodeNull()
            Me(Me.tableEmployees.PostalCodeColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsCountryNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.CountryColumn)
        End Function
        
        Public Sub SetCountryNull()
            Me(Me.tableEmployees.CountryColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsHomePhoneNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.HomePhoneColumn)
        End Function
        
        Public Sub SetHomePhoneNull()
            Me(Me.tableEmployees.HomePhoneColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsExtensionNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.ExtensionColumn)
        End Function
        
        Public Sub SetExtensionNull()
            Me(Me.tableEmployees.ExtensionColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhotoNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.PhotoColumn)
        End Function
        
        Public Sub SetPhotoNull()
            Me(Me.tableEmployees.PhotoColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsNotesNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.NotesColumn)
        End Function
        
        Public Sub SetNotesNull()
            Me(Me.tableEmployees.NotesColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsReportsToNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.ReportsToColumn)
        End Function
        
        Public Sub SetReportsToNull()
            Me(Me.tableEmployees.ReportsToColumn) = System.Convert.DBNull
        End Sub
        
        Public Function IsPhotoPathNull() As Boolean
            Return Me.IsNull(Me.tableEmployees.PhotoPathColumn)
        End Function
        
        Public Sub SetPhotoPathNull()
            Me(Me.tableEmployees.PhotoPathColumn) = System.Convert.DBNull
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThrough()>  _
    Public Class EmployeesRowChangeEvent
        Inherits EventArgs
        
        Private eventRow As EmployeesRow
        
        Private eventAction As DataRowAction
        
        Public Sub New(ByVal row As EmployeesRow, ByVal action As DataRowAction)
            MyBase.New
            Me.eventRow = row
            Me.eventAction = action
        End Sub
        
        Public ReadOnly Property Row As EmployeesRow
            Get
                Return Me.eventRow
            End Get
        End Property
        
        Public ReadOnly Property Action As DataRowAction
            Get
                Return Me.eventAction
            End Get
        End Property
    End Class
End Class
