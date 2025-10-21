namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SfnAliasState<'Name, 'RoutingConfiguration> = { assignments: ResizeArray<aws.SfnAlias.SfnAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_alias">aws_sfn_alias</a>.
    /// </summary>
    type SfnAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : SfnAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SfnAliasState<Missing, Missing>)

        member _.Zero(()) : SfnAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SfnAliasState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_alias#name-1">SfnAlias#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SfnAliasState<Missing, 'RoutingConfiguration>, value: string) : SfnAliasState<Present, 'RoutingConfiguration> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SfnAliasState<Present, 'RoutingConfiguration>)

        /// <summary>
        /// routing_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_alias#routing_configuration-1">SfnAlias#routing_configuration</a> Accepts: aws.IResolvable | aws.SfnAlias.SfnAliasRoutingConfiguration[]
        /// </summary>
        [<CustomOperation "routing_configuration">]
        member _.RoutingConfiguration(state: SfnAliasState<'Name, Missing>, value: HashiCorp.Cdktf.IResolvable) : SfnAliasState<'Name, Present> =
            state.assignments.Add(fun config -> config.RoutingConfiguration <- value)
            ({ assignments = state.assignments } : SfnAliasState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_alias#description-1">SfnAlias#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SfnAliasState<'Name, 'RoutingConfiguration>, value: string) : SfnAliasState<'Name, 'RoutingConfiguration> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SfnAliasState<'Name, 'RoutingConfiguration>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_alias#id-1">SfnAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SfnAliasState<'Name, 'RoutingConfiguration>, value: string) : SfnAliasState<'Name, 'RoutingConfiguration> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SfnAliasState<'Name, 'RoutingConfiguration>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_alias#timeouts-1">SfnAlias#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SfnAliasState<'Name, 'RoutingConfiguration>, value: aws.SfnAlias.SfnAliasTimeouts) : SfnAliasState<'Name, 'RoutingConfiguration> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SfnAliasState<'Name, 'RoutingConfiguration>

        member _.Run(state: SfnAliasState<Present, Present>) : aws.SfnAlias.SfnAlias =
            let config = aws.SfnAlias.SfnAliasConfig()
            for setter in state.assignments do
                setter config
            aws.SfnAlias.SfnAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sfnAlias: missing required arguments. Must call: name, routing_configuration.", 9999, IsError = true)>]
        member _.Run(_: SfnAliasState<_, _>) : aws.SfnAlias.SfnAlias =
            Unchecked.defaultof<aws.SfnAlias.SfnAlias>
