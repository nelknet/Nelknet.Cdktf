namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CustomProviderState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CustomProvider.CustomProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider">azurerm_custom_provider</a>.
    /// </summary>
    type CustomProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : CustomProviderState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CustomProviderState<Missing, Missing, Missing>)

        member _.Zero(()) : CustomProviderState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CustomProviderState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#location-1">CustomProvider#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: CustomProviderState<Missing, 'Name, 'ResourceGroupName>, value: string) : CustomProviderState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : CustomProviderState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#name-1">CustomProvider#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CustomProviderState<'Location, Missing, 'ResourceGroupName>, value: string) : CustomProviderState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CustomProviderState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#resource_group_name-1">CustomProvider#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CustomProviderState<'Location, 'Name, Missing>, value: string) : CustomProviderState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CustomProviderState<'Location, 'Name, Present>)

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#action-1">CustomProvider#action</a> Accepts: azurerm.IResolvable | azurerm.CustomProvider.CustomProviderAction[]
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: CustomProviderState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CustomProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Action <- value)
            state : CustomProviderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#id-1">CustomProvider#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CustomProviderState<'Location, 'Name, 'ResourceGroupName>, value: string) : CustomProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CustomProviderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// resource_type block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#resource_type-1">CustomProvider#resource_type</a> Accepts: azurerm.IResolvable | azurerm.CustomProvider.CustomProviderResourceType[]
        /// </summary>
        [<CustomOperation "resource_type">]
        member _.ResourceType(state: CustomProviderState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CustomProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ResourceType <- value)
            state : CustomProviderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#tags-1">CustomProvider#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CustomProviderState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : CustomProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CustomProviderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#timeouts-1">CustomProvider#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CustomProviderState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.CustomProvider.CustomProviderTimeouts) : CustomProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CustomProviderState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// validation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_provider#validation-1">CustomProvider#validation</a> Accepts: azurerm.IResolvable | azurerm.CustomProvider.CustomProviderValidation[]
        /// </summary>
        [<CustomOperation "validation">]
        member _.Validation(state: CustomProviderState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CustomProviderState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Validation <- value)
            state : CustomProviderState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: CustomProviderState<Present, Present, Present>) : azurerm.CustomProvider.CustomProvider =
            let config = azurerm.CustomProvider.CustomProviderConfig()
            for setter in state.assignments do
                setter config
            azurerm.CustomProvider.CustomProvider(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.customProvider: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CustomProviderState<_, _, _>) : azurerm.CustomProvider.CustomProvider =
            Unchecked.defaultof<azurerm.CustomProvider.CustomProvider>
