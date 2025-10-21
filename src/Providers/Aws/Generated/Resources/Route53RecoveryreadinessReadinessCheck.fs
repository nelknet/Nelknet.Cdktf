namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName> = { assignments: ResizeArray<aws.Route53RecoveryreadinessReadinessCheck.Route53RecoveryreadinessReadinessCheckConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_readiness_check">aws_route53recoveryreadiness_readiness_check</a>.
    /// </summary>
    type Route53RecoveryreadinessReadinessCheckBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53RecoveryreadinessReadinessCheckState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53RecoveryreadinessReadinessCheckState<Missing, Missing>)

        member _.Zero(()) : Route53RecoveryreadinessReadinessCheckState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53RecoveryreadinessReadinessCheckState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_readiness_check#readiness_check_name-1">Route53RecoveryreadinessReadinessCheck#readiness_check_name</a>.
        /// </summary>
        [<CustomOperation "readiness_check_name">]
        member _.ReadinessCheckName(state: Route53RecoveryreadinessReadinessCheckState<Missing, 'ResourceSetName>, value: string) : Route53RecoveryreadinessReadinessCheckState<Present, 'ResourceSetName> =
            state.assignments.Add(fun config -> config.ReadinessCheckName <- value)
            ({ assignments = state.assignments } : Route53RecoveryreadinessReadinessCheckState<Present, 'ResourceSetName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_readiness_check#resource_set_name-1">Route53RecoveryreadinessReadinessCheck#resource_set_name</a>.
        /// </summary>
        [<CustomOperation "resource_set_name">]
        member _.ResourceSetName(state: Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, Missing>, value: string) : Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, Present> =
            state.assignments.Add(fun config -> config.ResourceSetName <- value)
            ({ assignments = state.assignments } : Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_readiness_check#id-1">Route53RecoveryreadinessReadinessCheck#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName>, value: string) : Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_readiness_check#tags-1">Route53RecoveryreadinessReadinessCheck#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName>, value: seq<string * string>) : Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_readiness_check#tags_all-1">Route53RecoveryreadinessReadinessCheck#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName>, value: seq<string * string>) : Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_readiness_check#timeouts-1">Route53RecoveryreadinessReadinessCheck#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName>, value: aws.Route53RecoveryreadinessReadinessCheck.Route53RecoveryreadinessReadinessCheckTimeouts) : Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53RecoveryreadinessReadinessCheckState<'ReadinessCheckName, 'ResourceSetName>

        member _.Run(state: Route53RecoveryreadinessReadinessCheckState<Present, Present>) : aws.Route53RecoveryreadinessReadinessCheck.Route53RecoveryreadinessReadinessCheck =
            let config = aws.Route53RecoveryreadinessReadinessCheck.Route53RecoveryreadinessReadinessCheckConfig()
            for setter in state.assignments do
                setter config
            aws.Route53RecoveryreadinessReadinessCheck.Route53RecoveryreadinessReadinessCheck(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53RecoveryreadinessReadinessCheck: missing required arguments. Must call: readiness_check_name, resource_set_name.", 9999, IsError = true)>]
        member _.Run(_: Route53RecoveryreadinessReadinessCheckState<_, _>) : aws.Route53RecoveryreadinessReadinessCheck.Route53RecoveryreadinessReadinessCheck =
            Unchecked.defaultof<aws.Route53RecoveryreadinessReadinessCheck.Route53RecoveryreadinessReadinessCheck>
