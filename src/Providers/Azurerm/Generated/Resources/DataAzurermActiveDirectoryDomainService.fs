namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermActiveDirectoryDomainServiceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermActiveDirectoryDomainService.DataAzurermActiveDirectoryDomainServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/active_directory_domain_service">azurerm_active_directory_domain_service</a>.
    /// </summary>
    type DataAzurermActiveDirectoryDomainServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermActiveDirectoryDomainServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermActiveDirectoryDomainServiceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermActiveDirectoryDomainServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermActiveDirectoryDomainServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/active_directory_domain_service#name-1">DataAzurermActiveDirectoryDomainService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermActiveDirectoryDomainServiceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermActiveDirectoryDomainServiceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermActiveDirectoryDomainServiceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/active_directory_domain_service#resource_group_name-1">DataAzurermActiveDirectoryDomainService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermActiveDirectoryDomainServiceState<'Name, Missing>, value: string) : DataAzurermActiveDirectoryDomainServiceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermActiveDirectoryDomainServiceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/active_directory_domain_service#id-1">DataAzurermActiveDirectoryDomainService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermActiveDirectoryDomainServiceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermActiveDirectoryDomainServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermActiveDirectoryDomainServiceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/active_directory_domain_service#tags-1">DataAzurermActiveDirectoryDomainService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermActiveDirectoryDomainServiceState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermActiveDirectoryDomainServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermActiveDirectoryDomainServiceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/active_directory_domain_service#timeouts-1">DataAzurermActiveDirectoryDomainService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermActiveDirectoryDomainServiceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermActiveDirectoryDomainService.DataAzurermActiveDirectoryDomainServiceTimeouts) : DataAzurermActiveDirectoryDomainServiceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermActiveDirectoryDomainServiceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermActiveDirectoryDomainServiceState<Present, Present>) : azurerm.DataAzurermActiveDirectoryDomainService.DataAzurermActiveDirectoryDomainService =
            let config = azurerm.DataAzurermActiveDirectoryDomainService.DataAzurermActiveDirectoryDomainServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermActiveDirectoryDomainService.DataAzurermActiveDirectoryDomainService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermActiveDirectoryDomainService: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermActiveDirectoryDomainServiceState<_, _>) : azurerm.DataAzurermActiveDirectoryDomainService.DataAzurermActiveDirectoryDomainService =
            Unchecked.defaultof<azurerm.DataAzurermActiveDirectoryDomainService.DataAzurermActiveDirectoryDomainService>
