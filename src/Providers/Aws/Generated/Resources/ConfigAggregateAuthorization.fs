namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ConfigAggregateAuthorizationState<'AccountId, 'Region> = { assignments: ResizeArray<aws.ConfigAggregateAuthorization.ConfigAggregateAuthorizationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_aggregate_authorization">aws_config_aggregate_authorization</a>.
    /// </summary>
    type ConfigAggregateAuthorizationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ConfigAggregateAuthorizationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfigAggregateAuthorizationState<Missing, Missing>)

        member _.Zero(()) : ConfigAggregateAuthorizationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ConfigAggregateAuthorizationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_aggregate_authorization#account_id-1">ConfigAggregateAuthorization#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: ConfigAggregateAuthorizationState<Missing, 'Region>, value: string) : ConfigAggregateAuthorizationState<Present, 'Region> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : ConfigAggregateAuthorizationState<Present, 'Region>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_aggregate_authorization#region-1">ConfigAggregateAuthorization#region</a>.
        /// </summary>
        [<CustomOperation "region">]
        member _.Region(state: ConfigAggregateAuthorizationState<'AccountId, Missing>, value: string) : ConfigAggregateAuthorizationState<'AccountId, Present> =
            state.assignments.Add(fun config -> config.Region <- value)
            ({ assignments = state.assignments } : ConfigAggregateAuthorizationState<'AccountId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_aggregate_authorization#id-1">ConfigAggregateAuthorization#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ConfigAggregateAuthorizationState<'AccountId, 'Region>, value: string) : ConfigAggregateAuthorizationState<'AccountId, 'Region> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ConfigAggregateAuthorizationState<'AccountId, 'Region>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_aggregate_authorization#tags-1">ConfigAggregateAuthorization#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ConfigAggregateAuthorizationState<'AccountId, 'Region>, value: seq<string * string>) : ConfigAggregateAuthorizationState<'AccountId, 'Region> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ConfigAggregateAuthorizationState<'AccountId, 'Region>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_aggregate_authorization#tags_all-1">ConfigAggregateAuthorization#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ConfigAggregateAuthorizationState<'AccountId, 'Region>, value: seq<string * string>) : ConfigAggregateAuthorizationState<'AccountId, 'Region> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ConfigAggregateAuthorizationState<'AccountId, 'Region>

        member _.Run(state: ConfigAggregateAuthorizationState<Present, Present>) : aws.ConfigAggregateAuthorization.ConfigAggregateAuthorization =
            let config = aws.ConfigAggregateAuthorization.ConfigAggregateAuthorizationConfig()
            for setter in state.assignments do
                setter config
            aws.ConfigAggregateAuthorization.ConfigAggregateAuthorization(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.configAggregateAuthorization: missing required arguments. Must call: account_id, region.", 9999, IsError = true)>]
        member _.Run(_: ConfigAggregateAuthorizationState<_, _>) : aws.ConfigAggregateAuthorization.ConfigAggregateAuthorization =
            Unchecked.defaultof<aws.ConfigAggregateAuthorization.ConfigAggregateAuthorization>
