namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermEventgridDomainState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermEventgridDomain.DataAzurermEventgridDomainConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain">azurerm_eventgrid_domain</a>.
    /// </summary>
    type DataAzurermEventgridDomainBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermEventgridDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventgridDomainState<Missing, Missing>)

        member _.Zero(()) : DataAzurermEventgridDomainState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventgridDomainState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain#name-1">DataAzurermEventgridDomain#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermEventgridDomainState<Missing, 'ResourceGroupName>, value: string) : DataAzurermEventgridDomainState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermEventgridDomainState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain#resource_group_name-1">DataAzurermEventgridDomain#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermEventgridDomainState<'Name, Missing>, value: string) : DataAzurermEventgridDomainState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermEventgridDomainState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain#id-1">DataAzurermEventgridDomain#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermEventgridDomainState<'Name, 'ResourceGroupName>, value: string) : DataAzurermEventgridDomainState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermEventgridDomainState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain#timeouts-1">DataAzurermEventgridDomain#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermEventgridDomainState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermEventgridDomain.DataAzurermEventgridDomainTimeouts) : DataAzurermEventgridDomainState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermEventgridDomainState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermEventgridDomainState<Present, Present>) : azurerm.DataAzurermEventgridDomain.DataAzurermEventgridDomain =
            let config = azurerm.DataAzurermEventgridDomain.DataAzurermEventgridDomainConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermEventgridDomain.DataAzurermEventgridDomain(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermEventgridDomain: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermEventgridDomainState<_, _>) : azurerm.DataAzurermEventgridDomain.DataAzurermEventgridDomain =
            Unchecked.defaultof<azurerm.DataAzurermEventgridDomain.DataAzurermEventgridDomain>
