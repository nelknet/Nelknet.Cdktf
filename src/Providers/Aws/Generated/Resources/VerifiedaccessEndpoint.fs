namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> = { assignments: ResizeArray<aws.VerifiedaccessEndpoint.VerifiedaccessEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint">aws_verifiedaccess_endpoint</a>.
    /// </summary>
    type VerifiedaccessEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : VerifiedaccessEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VerifiedaccessEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : VerifiedaccessEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : VerifiedaccessEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#attachment_type-1">VerifiedaccessEndpoint#attachment_type</a>.
        /// </summary>
        [<CustomOperation "attachment_type">]
        member _.AttachmentType(state: VerifiedaccessEndpointState<Missing, 'EndpointType, 'VerifiedAccessGroupId>, value: string) : VerifiedaccessEndpointState<Present, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.AttachmentType <- value)
            ({ assignments = state.assignments } : VerifiedaccessEndpointState<Present, 'EndpointType, 'VerifiedAccessGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#endpoint_type-1">VerifiedaccessEndpoint#endpoint_type</a>.
        /// </summary>
        [<CustomOperation "endpoint_type">]
        member _.EndpointType(state: VerifiedaccessEndpointState<'AttachmentType, Missing, 'VerifiedAccessGroupId>, value: string) : VerifiedaccessEndpointState<'AttachmentType, Present, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.EndpointType <- value)
            ({ assignments = state.assignments } : VerifiedaccessEndpointState<'AttachmentType, Present, 'VerifiedAccessGroupId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#verified_access_group_id-1">VerifiedaccessEndpoint#verified_access_group_id</a>.
        /// </summary>
        [<CustomOperation "verified_access_group_id">]
        member _.VerifiedAccessGroupId(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, Missing>, value: string) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, Present> =
            state.assignments.Add(fun config -> config.VerifiedAccessGroupId <- value)
            ({ assignments = state.assignments } : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#application_domain-1">VerifiedaccessEndpoint#application_domain</a>.
        /// </summary>
        [<CustomOperation "application_domain">]
        member _.ApplicationDomain(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: string) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.ApplicationDomain <- value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// cidr_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#cidr_options-1">VerifiedaccessEndpoint#cidr_options</a>
        /// </summary>
        [<CustomOperation "cidr_options">]
        member _.CidrOptions(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: aws.VerifiedaccessEndpoint.VerifiedaccessEndpointCidrOptions) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.CidrOptions <- value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#description-1">VerifiedaccessEndpoint#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: string) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#domain_certificate_arn-1">VerifiedaccessEndpoint#domain_certificate_arn</a>.
        /// </summary>
        [<CustomOperation "domain_certificate_arn">]
        member _.DomainCertificateArn(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: string) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.DomainCertificateArn <- value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#endpoint_domain_prefix-1">VerifiedaccessEndpoint#endpoint_domain_prefix</a>.
        /// </summary>
        [<CustomOperation "endpoint_domain_prefix">]
        member _.EndpointDomainPrefix(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: string) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.EndpointDomainPrefix <- value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#id-1">VerifiedaccessEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: string) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// load_balancer_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#load_balancer_options-1">VerifiedaccessEndpoint#load_balancer_options</a>
        /// </summary>
        [<CustomOperation "load_balancer_options">]
        member _.LoadBalancerOptions(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: aws.VerifiedaccessEndpoint.VerifiedaccessEndpointLoadBalancerOptions) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.LoadBalancerOptions <- value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// network_interface_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#network_interface_options-1">VerifiedaccessEndpoint#network_interface_options</a>
        /// </summary>
        [<CustomOperation "network_interface_options">]
        member _.NetworkInterfaceOptions(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: aws.VerifiedaccessEndpoint.VerifiedaccessEndpointNetworkInterfaceOptions) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.NetworkInterfaceOptions <- value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#policy_document-1">VerifiedaccessEndpoint#policy_document</a>.
        /// </summary>
        [<CustomOperation "policy_document">]
        member _.PolicyDocument(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: string) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.PolicyDocument <- value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// rds_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#rds_options-1">VerifiedaccessEndpoint#rds_options</a>
        /// </summary>
        [<CustomOperation "rds_options">]
        member _.RdsOptions(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: aws.VerifiedaccessEndpoint.VerifiedaccessEndpointRdsOptions) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.RdsOptions <- value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#security_group_ids-1">VerifiedaccessEndpoint#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: seq<string>) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// sse_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#sse_specification-1">VerifiedaccessEndpoint#sse_specification</a>
        /// </summary>
        [<CustomOperation "sse_specification">]
        member _.SseSpecification(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: aws.VerifiedaccessEndpoint.VerifiedaccessEndpointSseSpecification) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.SseSpecification <- value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#tags-1">VerifiedaccessEndpoint#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: seq<string * string>) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#tags_all-1">VerifiedaccessEndpoint#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: seq<string * string>) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#timeouts-1">VerifiedaccessEndpoint#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>, value: aws.VerifiedaccessEndpoint.VerifiedaccessEndpointTimeouts) : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : VerifiedaccessEndpointState<'AttachmentType, 'EndpointType, 'VerifiedAccessGroupId>

        member _.Run(state: VerifiedaccessEndpointState<Present, Present, Present>) : aws.VerifiedaccessEndpoint.VerifiedaccessEndpoint =
            let config = aws.VerifiedaccessEndpoint.VerifiedaccessEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.VerifiedaccessEndpoint.VerifiedaccessEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.verifiedaccessEndpoint: missing required arguments. Must call: attachment_type, endpoint_type, verified_access_group_id.", 9999, IsError = true)>]
        member _.Run(_: VerifiedaccessEndpointState<_, _, _>) : aws.VerifiedaccessEndpoint.VerifiedaccessEndpoint =
            Unchecked.defaultof<aws.VerifiedaccessEndpoint.VerifiedaccessEndpoint>
