Imports System.ComponentModel
Imports System.Reflection

Public Module EnumeracionesAuxiliares

    Public Enum ModificadorAcceso
        <Description("Public")> _
        PublicAccess
        <Description("Protected")> _
        ProtectedAccess
        <Description("Friend")> _
        FriendAccess
        <Description("ProtectedFriend")> _
        ProtectedFriendAccess
        <Description("Private")> _
        PrivateAccess
    End Enum

    Public Enum ModificadorHerencia
        <Description("")> _
        NoInheritanceModifier
        <Description("MustInherit")> _
        MustInheritModifier
        <Description("NotInheritable")> _
        NotInheritableModifier
    End Enum

End Module
