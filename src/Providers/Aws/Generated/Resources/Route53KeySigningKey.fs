namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, 'Name> = { assignments: ResizeArray<aws.Route53KeySigningKey.Route53KeySigningKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_key_signing_key">aws_route53_key_signing_key</a>.
    /// </summary>
    type Route53KeySigningKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53KeySigningKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53KeySigningKeyState<Missing, Missing, Missing>)

        member _.Zero(()) : Route53KeySigningKeyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53KeySigningKeyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_key_signing_key#hosted_zone_id-1">Route53KeySigningKey#hosted_zone_id</a>.
        /// </summary>
        [<CustomOperation "hosted_zone_id">]
        member _.HostedZoneId(state: Route53KeySigningKeyState<Missing, 'KeyManagementServiceArn, 'Name>, value: string) : Route53KeySigningKeyState<Present, 'KeyManagementServiceArn, 'Name> =
            state.assignments.Add(fun config -> config.HostedZoneId <- value)
            ({ assignments = state.assignments } : Route53KeySigningKeyState<Present, 'KeyManagementServiceArn, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_key_signing_key#key_management_service_arn-1">Route53KeySigningKey#key_management_service_arn</a>.
        /// </summary>
        [<CustomOperation "key_management_service_arn">]
        member _.KeyManagementServiceArn(state: Route53KeySigningKeyState<'HostedZoneId, Missing, 'Name>, value: string) : Route53KeySigningKeyState<'HostedZoneId, Present, 'Name> =
            state.assignments.Add(fun config -> config.KeyManagementServiceArn <- value)
            ({ assignments = state.assignments } : Route53KeySigningKeyState<'HostedZoneId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_key_signing_key#name-1">Route53KeySigningKey#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, Missing>, value: string) : Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_key_signing_key#id-1">Route53KeySigningKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, 'Name>, value: string) : Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_key_signing_key#status-1">Route53KeySigningKey#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, 'Name>, value: string) : Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, 'Name> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53_key_signing_key#timeouts-1">Route53KeySigningKey#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, 'Name>, value: aws.Route53KeySigningKey.Route53KeySigningKeyTimeouts) : Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53KeySigningKeyState<'HostedZoneId, 'KeyManagementServiceArn, 'Name>

        member _.Run(state: Route53KeySigningKeyState<Present, Present, Present>) : aws.Route53KeySigningKey.Route53KeySigningKey =
            let config = aws.Route53KeySigningKey.Route53KeySigningKeyConfig()
            for setter in state.assignments do
                setter config
            aws.Route53KeySigningKey.Route53KeySigningKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53KeySigningKey: missing required arguments. Must call: hosted_zone_id, key_management_service_arn, name.", 9999, IsError = true)>]
        member _.Run(_: Route53KeySigningKeyState<_, _, _>) : aws.Route53KeySigningKey.Route53KeySigningKey =
            Unchecked.defaultof<aws.Route53KeySigningKey.Route53KeySigningKey>
