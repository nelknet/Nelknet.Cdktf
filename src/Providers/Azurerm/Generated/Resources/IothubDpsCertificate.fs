namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IothubDpsCertificate.IothubDpsCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_certificate">azurerm_iothub_dps_certificate</a>.
    /// </summary>
    type IothubDpsCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubDpsCertificateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubDpsCertificateState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IothubDpsCertificateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubDpsCertificateState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_certificate#certificate_content-1">IothubDpsCertificate#certificate_content</a>.
        /// </summary>
        [<CustomOperation "certificate_content">]
        member _.CertificateContent(state: IothubDpsCertificateState<Missing, 'IotDpsName, 'Name, 'ResourceGroupName>, value: string) : IothubDpsCertificateState<Present, 'IotDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CertificateContent <- value)
            ({ assignments = state.assignments } : IothubDpsCertificateState<Present, 'IotDpsName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_certificate#iot_dps_name-1">IothubDpsCertificate#iot_dps_name</a>.
        /// </summary>
        [<CustomOperation "iot_dps_name">]
        member _.IotDpsName(state: IothubDpsCertificateState<'CertificateContent, Missing, 'Name, 'ResourceGroupName>, value: string) : IothubDpsCertificateState<'CertificateContent, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IotDpsName <- value)
            ({ assignments = state.assignments } : IothubDpsCertificateState<'CertificateContent, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_certificate#name-1">IothubDpsCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubDpsCertificateState<'CertificateContent, 'IotDpsName, Missing, 'ResourceGroupName>, value: string) : IothubDpsCertificateState<'CertificateContent, 'IotDpsName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubDpsCertificateState<'CertificateContent, 'IotDpsName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_certificate#resource_group_name-1">IothubDpsCertificate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, Missing>, value: string) : IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_certificate#id-1">IothubDpsCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName>, value: string) : IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_certificate#is_verified-1">IothubDpsCertificate#is_verified</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_verified">]
        member _.IsVerified(state: IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName>, value: bool) : IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsVerified <- value)
            state : IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_certificate#is_verified-1">IothubDpsCertificate#is_verified</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_verified">]
        member _.IsVerified(state: IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsVerified <- value)
            state : IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_dps_certificate#timeouts-1">IothubDpsCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName>, value: azurerm.IothubDpsCertificate.IothubDpsCertificateTimeouts) : IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubDpsCertificateState<'CertificateContent, 'IotDpsName, 'Name, 'ResourceGroupName>

        member _.Run(state: IothubDpsCertificateState<Present, Present, Present, Present>) : azurerm.IothubDpsCertificate.IothubDpsCertificate =
            let config = azurerm.IothubDpsCertificate.IothubDpsCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubDpsCertificate.IothubDpsCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubDpsCertificate: missing required arguments. Must call: certificate_content, iot_dps_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IothubDpsCertificateState<_, _, _, _>) : azurerm.IothubDpsCertificate.IothubDpsCertificate =
            Unchecked.defaultof<azurerm.IothubDpsCertificate.IothubDpsCertificate>
