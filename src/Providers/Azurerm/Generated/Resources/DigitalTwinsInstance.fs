namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DigitalTwinsInstance.DigitalTwinsInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_instance">azurerm_digital_twins_instance</a>.
    /// </summary>
    type DigitalTwinsInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DigitalTwinsInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DigitalTwinsInstanceState<Missing, Missing, Missing>)

        member _.Zero(()) : DigitalTwinsInstanceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DigitalTwinsInstanceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_instance#location-1">DigitalTwinsInstance#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DigitalTwinsInstanceState<Missing, 'Name, 'ResourceGroupName>, value: string) : DigitalTwinsInstanceState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DigitalTwinsInstanceState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_instance#name-1">DigitalTwinsInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DigitalTwinsInstanceState<'Location, Missing, 'ResourceGroupName>, value: string) : DigitalTwinsInstanceState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DigitalTwinsInstanceState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_instance#resource_group_name-1">DigitalTwinsInstance#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DigitalTwinsInstanceState<'Location, 'Name, Missing>, value: string) : DigitalTwinsInstanceState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DigitalTwinsInstanceState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_instance#id-1">DigitalTwinsInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName>, value: string) : DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_instance#identity-1">DigitalTwinsInstance#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DigitalTwinsInstance.DigitalTwinsInstanceIdentity) : DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_instance#tags-1">DigitalTwinsInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/digital_twins_instance#timeouts-1">DigitalTwinsInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DigitalTwinsInstance.DigitalTwinsInstanceTimeouts) : DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DigitalTwinsInstanceState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: DigitalTwinsInstanceState<Present, Present, Present>) : azurerm.DigitalTwinsInstance.DigitalTwinsInstance =
            let config = azurerm.DigitalTwinsInstance.DigitalTwinsInstanceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DigitalTwinsInstance.DigitalTwinsInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.digitalTwinsInstance: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DigitalTwinsInstanceState<_, _, _>) : azurerm.DigitalTwinsInstance.DigitalTwinsInstance =
            Unchecked.defaultof<azurerm.DigitalTwinsInstance.DigitalTwinsInstance>
