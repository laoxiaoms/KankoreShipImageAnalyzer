﻿'------------------------------------------------------------------------------
' <auto-generated>
'     此代码由工具生成。
'     运行时版本:4.0.30319.42000
'
'     对此文件的更改可能会导致不正确的行为，并且如果
'     重新生成代码，这些更改将会丢失。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    '此类是由 StronglyTypedResourceBuilder
    '类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    '若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    '(以 /str 作为命令选项)，或重新生成 VS 项目。
    '''<summary>
    '''  一个强类型的资源类，用于查找本地化的字符串等。
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  返回此类使用的缓存的 ResourceManager 实例。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("KankoreShipImageAnalyzer.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  使用此强类型资源类，为所有资源查找
        '''  重写当前线程的 CurrentUICulture 属性。
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property Big_Err_img() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Big_Err_img", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  查找类似 1|睦月|むつき
        '''2|如月|きさらぎ
        '''6|長月|ながつき
        '''7|三日月|みかづき
        '''9|吹雪|ふぶき
        '''10|白雪|しらゆき
        '''11|深雪|みゆき
        '''12|磯波|いそなみ
        '''13|綾波|あやなみ
        '''14|敷波|しきなみ
        '''15|曙|あけぼの
        '''16|潮|うしお
        '''17|陽炎|かげろう
        '''18|不知火|しらぬい
        '''19|黒潮|くろしお
        '''20|雪風|ゆきかぜ
        '''21|長良|ながら
        '''22|五十鈴|いすず
        '''23|由良|ゆら
        '''24|大井|おおい
        '''25|北上|きたかみ
        '''26|扶桑|ふそう
        '''27|山城|やましろ
        '''28|皐月|さつき
        '''29|文月|ふみづき
        '''30|菊月|きくづき
        '''31|望月|もちづき
        '''32|初雪|はつゆき
        '''33|叢雲|むらくも
        '''34|暁|あかつき
        '''35|響|ひびき
        '''36|雷|いかづち
        '''37|電|いなづま
        '''38|初春|はつはる
        '''39|子日|ねのひ
        '''40|若葉|わかば
        '''41|初霜|はつしも
        '''42|白露|しらつゆ
        '''43|時雨|しぐれ
        '''44|村雨|むらさめ
        '''45|夕立|ゆうだち
        '''46|五月雨|さみだれ
        '''47|涼風|すずかぜ
        '''48|霰|あられ
        '''49|霞|かすみ [字符串的其余部分被截断]&quot;; 的本地化字符串。
        '''</summary>
        Friend ReadOnly Property List_Names() As String
            Get
                Return ResourceManager.GetString("List_Names", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  查找 System.Drawing.Bitmap 类型的本地化资源。
        '''</summary>
        Friend ReadOnly Property Main_Err_img() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Main_Err_img", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
