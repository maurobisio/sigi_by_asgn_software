﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class RecursoLenguajeENG
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("sigesi.RecursoLenguajeENG", GetType(RecursoLenguajeENG).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Back.
        '''</summary>
        Friend Shared ReadOnly Property btnAtras() As String
            Get
                Return ResourceManager.GetString("btnAtras", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Search.
        '''</summary>
        Friend Shared ReadOnly Property btnBuscar() As String
            Get
                Return ResourceManager.GetString("btnBuscar", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Enter.
        '''</summary>
        Friend Shared ReadOnly Property btnEntrar() As String
            Get
                Return ResourceManager.GetString("btnEntrar", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Search student.
        '''</summary>
        Friend Shared ReadOnly Property gpbBuscarAlumnos() As String
            Get
                Return ResourceManager.GetString("gpbBuscarAlumnos", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Administrative.
        '''</summary>
        Friend Shared ReadOnly Property lblAdministrativo() As String
            Get
                Return ResourceManager.GetString("lblAdministrativo", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to System administrator.
        '''</summary>
        Friend Shared ReadOnly Property lblAdminSist() As String
            Get
                Return ResourceManager.GetString("lblAdminSist", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Student.
        '''</summary>
        Friend Shared ReadOnly Property lblAlu() As String
            Get
                Return ResourceManager.GetString("lblAlu", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Course.
        '''</summary>
        Friend Shared ReadOnly Property lblCurso() As String
            Get
                Return ResourceManager.GetString("lblCurso", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Director.
        '''</summary>
        Friend Shared ReadOnly Property lblDirector() As String
            Get
                Return ResourceManager.GetString("lblDirector", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Teacher.
        '''</summary>
        Friend Shared ReadOnly Property lblDocente() As String
            Get
                Return ResourceManager.GetString("lblDocente", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Password.
        '''</summary>
        Friend Shared ReadOnly Property lblPwd() As String
            Get
                Return ResourceManager.GetString("lblPwd", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Choose your type of user.
        '''</summary>
        Friend Shared ReadOnly Property lblSelecUsu() As String
            Get
                Return ResourceManager.GetString("lblSelecUsu", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to User.
        '''</summary>
        Friend Shared ReadOnly Property lblUsu() As String
            Get
                Return ResourceManager.GetString("lblUsu", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
