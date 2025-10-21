namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IothubCertificate.IothubCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_certificate">azurerm_iothub_certificate</a>.
    /// </summary>
    type IothubCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubCertificateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubCertificateState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IothubCertificateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubCertificateState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_certificate#certificate_content-1">IothubCertificate#certificate_content</a>.
        /// </summary>
        [<CustomOperation "certificate_content">]
        member _.CertificateContent(state: IothubCertificateState<Missing, 'IothubName, 'Name, 'ResourceGroupName>, value: string) : IothubCertificateState<Present, 'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CertificateContent <- value)
            ({ assignments = state.assignments } : IothubCertificateState<Present, 'IothubName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_certificate#iothub_name-1">IothubCertificate#iothub_name</a>.
        /// </summary>
        [<CustomOperation "iothub_name">]
        member _.IothubName(state: IothubCertificateState<'CertificateContent, Missing, 'Name, 'ResourceGroupName>, value: string) : IothubCertificateState<'CertificateContent, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubName <- value)
            ({ assignments = state.assignments } : IothubCertificateState<'CertificateContent, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_certificate#name-1">IothubCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubCertificateState<'CertificateContent, 'IothubName, Missing, 'ResourceGroupName>, value: string) : IothubCertificateState<'CertificateContent, 'IothubName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubCertificateState<'CertificateContent, 'IothubName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_certificate#resource_group_name-1">IothubCertificate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubCertificateState<'CertificateContent, 'IothubName, 'Name, Missing>, value: string) : IothubCertificateState<'CertificateContent, 'IothubName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubCertificateState<'CertificateContent, 'IothubName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_certificate#id-1">IothubCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName>, value: string) : IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_certificate#is_verified-1">IothubCertificate#is_verified</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_verified">]
        member _.IsVerified(state: IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName>, value: bool) : IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsVerified <- value)
            state : IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_certificate#is_verified-1">IothubCertificate#is_verified</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_verified">]
        member _.IsVerified(state: IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsVerified <- value)
            state : IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_certificate#timeouts-1">IothubCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName>, value: azurerm.IothubCertificate.IothubCertificateTimeouts) : IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubCertificateState<'CertificateContent, 'IothubName, 'Name, 'ResourceGroupName>

        member _.Run(state: IothubCertificateState<Present, Present, Present, Present>) : azurerm.IothubCertificate.IothubCertificate =
            let config = azurerm.IothubCertificate.IothubCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubCertificate.IothubCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubCertificate: missing required arguments. Must call: certificate_content, iothub_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IothubCertificateState<_, _, _, _>) : azurerm.IothubCertificate.IothubCertificate =
            Unchecked.defaultof<azurerm.IothubCertificate.IothubCertificate>
