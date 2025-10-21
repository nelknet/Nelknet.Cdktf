namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AccountRegionState<'Enabled, 'RegionName> = { assignments: ResizeArray<aws.AccountRegion.AccountRegionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_region">aws_account_region</a>.
    /// </summary>
    type AccountRegionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AccountRegionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AccountRegionState<Missing, Missing>)

        member _.Zero(()) : AccountRegionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AccountRegionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_region#enabled-1">AccountRegion#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AccountRegionState<Missing, 'RegionName>, value: bool) : AccountRegionState<Present, 'RegionName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : AccountRegionState<Present, 'RegionName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_region#enabled-1">AccountRegion#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AccountRegionState<Missing, 'RegionName>, value: HashiCorp.Cdktf.IResolvable) : AccountRegionState<Present, 'RegionName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : AccountRegionState<Present, 'RegionName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_region#region_name-1">AccountRegion#region_name</a>.
        /// </summary>
        [<CustomOperation "region_name">]
        member _.RegionName(state: AccountRegionState<'Enabled, Missing>, value: string) : AccountRegionState<'Enabled, Present> =
            state.assignments.Add(fun config -> config.RegionName <- value)
            ({ assignments = state.assignments } : AccountRegionState<'Enabled, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_region#account_id-1">AccountRegion#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: AccountRegionState<'Enabled, 'RegionName>, value: string) : AccountRegionState<'Enabled, 'RegionName> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : AccountRegionState<'Enabled, 'RegionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_region#id-1">AccountRegion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AccountRegionState<'Enabled, 'RegionName>, value: string) : AccountRegionState<'Enabled, 'RegionName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AccountRegionState<'Enabled, 'RegionName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/account_region#timeouts-1">AccountRegion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AccountRegionState<'Enabled, 'RegionName>, value: aws.AccountRegion.AccountRegionTimeouts) : AccountRegionState<'Enabled, 'RegionName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AccountRegionState<'Enabled, 'RegionName>

        member _.Run(state: AccountRegionState<Present, Present>) : aws.AccountRegion.AccountRegion =
            let config = aws.AccountRegion.AccountRegionConfig()
            for setter in state.assignments do
                setter config
            aws.AccountRegion.AccountRegion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.accountRegion: missing required arguments. Must call: enabled, region_name.", 9999, IsError = true)>]
        member _.Run(_: AccountRegionState<_, _>) : aws.AccountRegion.AccountRegion =
            Unchecked.defaultof<aws.AccountRegion.AccountRegion>
