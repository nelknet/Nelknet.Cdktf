namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAppServiceCertificateState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAppServiceCertificate.DataAzurermAppServiceCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate">azurerm_app_service_certificate</a>.
    /// </summary>
    type DataAzurermAppServiceCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAppServiceCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppServiceCertificateState<Missing, Missing>)

        member _.Zero(()) : DataAzurermAppServiceCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAppServiceCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate#name-1">DataAzurermAppServiceCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermAppServiceCertificateState<Missing, 'ResourceGroupName>, value: string) : DataAzurermAppServiceCertificateState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermAppServiceCertificateState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate#resource_group_name-1">DataAzurermAppServiceCertificate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAppServiceCertificateState<'Name, Missing>, value: string) : DataAzurermAppServiceCertificateState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAppServiceCertificateState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate#id-1">DataAzurermAppServiceCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAppServiceCertificateState<'Name, 'ResourceGroupName>, value: string) : DataAzurermAppServiceCertificateState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAppServiceCertificateState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate#tags-1">DataAzurermAppServiceCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermAppServiceCertificateState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermAppServiceCertificateState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermAppServiceCertificateState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_certificate#timeouts-1">DataAzurermAppServiceCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAppServiceCertificateState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermAppServiceCertificate.DataAzurermAppServiceCertificateTimeouts) : DataAzurermAppServiceCertificateState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAppServiceCertificateState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermAppServiceCertificateState<Present, Present>) : azurerm.DataAzurermAppServiceCertificate.DataAzurermAppServiceCertificate =
            let config = azurerm.DataAzurermAppServiceCertificate.DataAzurermAppServiceCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAppServiceCertificate.DataAzurermAppServiceCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAppServiceCertificate: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAppServiceCertificateState<_, _>) : azurerm.DataAzurermAppServiceCertificate.DataAzurermAppServiceCertificate =
            Unchecked.defaultof<azurerm.DataAzurermAppServiceCertificate.DataAzurermAppServiceCertificate>
