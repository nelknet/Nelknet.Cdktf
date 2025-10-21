namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CustomIpPrefix.CustomIpPrefixConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix">azurerm_custom_ip_prefix</a>.
    /// </summary>
    type CustomIpPrefixBuilder(logicalId: string) =
        member _.Yield(_: unit) : CustomIpPrefixState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CustomIpPrefixState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CustomIpPrefixState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CustomIpPrefixState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#cidr-1">CustomIpPrefix#cidr</a>.
        /// </summary>
        [<CustomOperation "cidr">]
        member _.Cidr(state: CustomIpPrefixState<Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : CustomIpPrefixState<Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Cidr <- value)
            ({ assignments = state.assignments } : CustomIpPrefixState<Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#location-1">CustomIpPrefix#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: CustomIpPrefixState<'Cidr, Missing, 'Name, 'ResourceGroupName>, value: string) : CustomIpPrefixState<'Cidr, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : CustomIpPrefixState<'Cidr, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#name-1">CustomIpPrefix#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CustomIpPrefixState<'Cidr, 'Location, Missing, 'ResourceGroupName>, value: string) : CustomIpPrefixState<'Cidr, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CustomIpPrefixState<'Cidr, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#resource_group_name-1">CustomIpPrefix#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CustomIpPrefixState<'Cidr, 'Location, 'Name, Missing>, value: string) : CustomIpPrefixState<'Cidr, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CustomIpPrefixState<'Cidr, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#commissioning_enabled-1">CustomIpPrefix#commissioning_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "commissioning_enabled">]
        member _.CommissioningEnabled(state: CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>, value: bool) : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CommissioningEnabled <- value)
            state : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#commissioning_enabled-1">CustomIpPrefix#commissioning_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "commissioning_enabled">]
        member _.CommissioningEnabled(state: CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CommissioningEnabled <- value)
            state : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#id-1">CustomIpPrefix#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>, value: string) : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#internet_advertising_disabled-1">CustomIpPrefix#internet_advertising_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_advertising_disabled">]
        member _.InternetAdvertisingDisabled(state: CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>, value: bool) : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternetAdvertisingDisabled <- value)
            state : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#internet_advertising_disabled-1">CustomIpPrefix#internet_advertising_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internet_advertising_disabled">]
        member _.InternetAdvertisingDisabled(state: CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternetAdvertisingDisabled <- value)
            state : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#parent_custom_ip_prefix_id-1">CustomIpPrefix#parent_custom_ip_prefix_id</a>.
        /// </summary>
        [<CustomOperation "parent_custom_ip_prefix_id">]
        member _.ParentCustomIpPrefixId(state: CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>, value: string) : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ParentCustomIpPrefixId <- value)
            state : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#roa_validity_end_date-1">CustomIpPrefix#roa_validity_end_date</a>.
        /// </summary>
        [<CustomOperation "roa_validity_end_date">]
        member _.RoaValidityEndDate(state: CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>, value: string) : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.RoaValidityEndDate <- value)
            state : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#tags-1">CustomIpPrefix#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#timeouts-1">CustomIpPrefix#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.CustomIpPrefix.CustomIpPrefixTimeouts) : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#wan_validation_signed_message-1">CustomIpPrefix#wan_validation_signed_message</a>.
        /// </summary>
        [<CustomOperation "wan_validation_signed_message">]
        member _.WanValidationSignedMessage(state: CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>, value: string) : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WanValidationSignedMessage <- value)
            state : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/custom_ip_prefix#zones-1">CustomIpPrefix#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>, value: seq<string>) : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : CustomIpPrefixState<'Cidr, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: CustomIpPrefixState<Present, Present, Present, Present>) : azurerm.CustomIpPrefix.CustomIpPrefix =
            let config = azurerm.CustomIpPrefix.CustomIpPrefixConfig()
            for setter in state.assignments do
                setter config
            azurerm.CustomIpPrefix.CustomIpPrefix(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.customIpPrefix: missing required arguments. Must call: cidr, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CustomIpPrefixState<_, _, _, _>) : azurerm.CustomIpPrefix.CustomIpPrefix =
            Unchecked.defaultof<azurerm.CustomIpPrefix.CustomIpPrefix>
