namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, 'TrafficPolicyId, 'TrafficPolicyVersion, 'Ttl> = { assignments: ResizeArray<aws.Route53TrafficPolicyInstance.Route53TrafficPolicyInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_traffic_policy_instance">aws_route53_traffic_policy_instance</a>.
    /// </summary>
    type Route53TrafficPolicyInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53TrafficPolicyInstanceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53TrafficPolicyInstanceState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Route53TrafficPolicyInstanceState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53TrafficPolicyInstanceState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_traffic_policy_instance#hosted_zone_id-1">Route53TrafficPolicyInstance#hosted_zone_id</a>.
        /// </summary>
        [<CustomOperation "hosted_zone_id">]
        member _.HostedZoneId(state: Route53TrafficPolicyInstanceState<Missing, 'Name, 'TrafficPolicyId, 'TrafficPolicyVersion, 'Ttl>, value: string) : Route53TrafficPolicyInstanceState<Present, 'Name, 'TrafficPolicyId, 'TrafficPolicyVersion, 'Ttl> =
            state.assignments.Add(fun config -> config.HostedZoneId <- value)
            ({ assignments = state.assignments } : Route53TrafficPolicyInstanceState<Present, 'Name, 'TrafficPolicyId, 'TrafficPolicyVersion, 'Ttl>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_traffic_policy_instance#name-1">Route53TrafficPolicyInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53TrafficPolicyInstanceState<'HostedZoneId, Missing, 'TrafficPolicyId, 'TrafficPolicyVersion, 'Ttl>, value: string) : Route53TrafficPolicyInstanceState<'HostedZoneId, Present, 'TrafficPolicyId, 'TrafficPolicyVersion, 'Ttl> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53TrafficPolicyInstanceState<'HostedZoneId, Present, 'TrafficPolicyId, 'TrafficPolicyVersion, 'Ttl>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_traffic_policy_instance#traffic_policy_id-1">Route53TrafficPolicyInstance#traffic_policy_id</a>.
        /// </summary>
        [<CustomOperation "traffic_policy_id">]
        member _.TrafficPolicyId(state: Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, Missing, 'TrafficPolicyVersion, 'Ttl>, value: string) : Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, Present, 'TrafficPolicyVersion, 'Ttl> =
            state.assignments.Add(fun config -> config.TrafficPolicyId <- value)
            ({ assignments = state.assignments } : Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, Present, 'TrafficPolicyVersion, 'Ttl>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_traffic_policy_instance#traffic_policy_version-1">Route53TrafficPolicyInstance#traffic_policy_version</a>.
        /// </summary>
        [<CustomOperation "traffic_policy_version">]
        member _.TrafficPolicyVersion(state: Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, 'TrafficPolicyId, Missing, 'Ttl>, value: double) : Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, 'TrafficPolicyId, Present, 'Ttl> =
            state.assignments.Add(fun config -> config.TrafficPolicyVersion <- value)
            ({ assignments = state.assignments } : Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, 'TrafficPolicyId, Present, 'Ttl>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_traffic_policy_instance#ttl-1">Route53TrafficPolicyInstance#ttl</a>.
        /// </summary>
        [<CustomOperation "ttl">]
        member _.Ttl(state: Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, 'TrafficPolicyId, 'TrafficPolicyVersion, Missing>, value: double) : Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, 'TrafficPolicyId, 'TrafficPolicyVersion, Present> =
            state.assignments.Add(fun config -> config.Ttl <- value)
            ({ assignments = state.assignments } : Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, 'TrafficPolicyId, 'TrafficPolicyVersion, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_traffic_policy_instance#id-1">Route53TrafficPolicyInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, 'TrafficPolicyId, 'TrafficPolicyVersion, 'Ttl>, value: string) : Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, 'TrafficPolicyId, 'TrafficPolicyVersion, 'Ttl> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53TrafficPolicyInstanceState<'HostedZoneId, 'Name, 'TrafficPolicyId, 'TrafficPolicyVersion, 'Ttl>

        member _.Run(state: Route53TrafficPolicyInstanceState<Present, Present, Present, Present, Present>) : aws.Route53TrafficPolicyInstance.Route53TrafficPolicyInstance =
            let config = aws.Route53TrafficPolicyInstance.Route53TrafficPolicyInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.Route53TrafficPolicyInstance.Route53TrafficPolicyInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53TrafficPolicyInstance: missing required arguments. Must call: hosted_zone_id, name, traffic_policy_id, traffic_policy_version, ttl.", 9999, IsError = true)>]
        member _.Run(_: Route53TrafficPolicyInstanceState<_, _, _, _, _>) : aws.Route53TrafficPolicyInstance.Route53TrafficPolicyInstance =
            Unchecked.defaultof<aws.Route53TrafficPolicyInstance.Route53TrafficPolicyInstance>
