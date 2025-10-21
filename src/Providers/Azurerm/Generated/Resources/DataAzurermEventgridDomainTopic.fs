namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermEventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermEventgridDomainTopic.DataAzurermEventgridDomainTopicConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain_topic">azurerm_eventgrid_domain_topic</a>.
    /// </summary>
    type DataAzurermEventgridDomainTopicBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermEventgridDomainTopicState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventgridDomainTopicState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermEventgridDomainTopicState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventgridDomainTopicState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain_topic#domain_name-1">DataAzurermEventgridDomainTopic#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: DataAzurermEventgridDomainTopicState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermEventgridDomainTopicState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : DataAzurermEventgridDomainTopicState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain_topic#name-1">DataAzurermEventgridDomainTopic#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermEventgridDomainTopicState<'DomainName, Missing, 'ResourceGroupName>, value: string) : DataAzurermEventgridDomainTopicState<'DomainName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermEventgridDomainTopicState<'DomainName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain_topic#resource_group_name-1">DataAzurermEventgridDomainTopic#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermEventgridDomainTopicState<'DomainName, 'Name, Missing>, value: string) : DataAzurermEventgridDomainTopicState<'DomainName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermEventgridDomainTopicState<'DomainName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain_topic#id-1">DataAzurermEventgridDomainTopic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermEventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermEventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermEventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventgrid_domain_topic#timeouts-1">DataAzurermEventgridDomainTopic#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermEventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermEventgridDomainTopic.DataAzurermEventgridDomainTopicTimeouts) : DataAzurermEventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermEventgridDomainTopicState<'DomainName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermEventgridDomainTopicState<Present, Present, Present>) : azurerm.DataAzurermEventgridDomainTopic.DataAzurermEventgridDomainTopic =
            let config = azurerm.DataAzurermEventgridDomainTopic.DataAzurermEventgridDomainTopicConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermEventgridDomainTopic.DataAzurermEventgridDomainTopic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermEventgridDomainTopic: missing required arguments. Must call: domain_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermEventgridDomainTopicState<_, _, _>) : azurerm.DataAzurermEventgridDomainTopic.DataAzurermEventgridDomainTopic =
            Unchecked.defaultof<azurerm.DataAzurermEventgridDomainTopic.DataAzurermEventgridDomainTopic>
