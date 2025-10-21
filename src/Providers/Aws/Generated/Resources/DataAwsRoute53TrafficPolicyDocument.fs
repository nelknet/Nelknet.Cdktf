namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRoute53TrafficPolicyDocumentState = { assignments: ResizeArray<aws.DataAwsRoute53TrafficPolicyDocument.DataAwsRoute53TrafficPolicyDocumentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document">aws_route53_traffic_policy_document</a>.
    /// </summary>
    type DataAwsRoute53TrafficPolicyDocumentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRoute53TrafficPolicyDocumentState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsRoute53TrafficPolicyDocumentState =
            { assignments = ResizeArray() }

        /// <summary>
        /// endpoint block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#endpoint-1">DataAwsRoute53TrafficPolicyDocument#endpoint</a> Accepts: aws.IResolvable | aws.DataAwsRoute53TrafficPolicyDocument.DataAwsRoute53TrafficPolicyDocumentEndpoint[]
        /// </summary>
        [<CustomOperation "endpoint">]
        member _.Endpoint(state: DataAwsRoute53TrafficPolicyDocumentState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRoute53TrafficPolicyDocumentState =
            state.assignments.Add(fun config -> config.Endpoint <- value)
            state : DataAwsRoute53TrafficPolicyDocumentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#id-1">DataAwsRoute53TrafficPolicyDocument#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRoute53TrafficPolicyDocumentState, value: string) : DataAwsRoute53TrafficPolicyDocumentState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRoute53TrafficPolicyDocumentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#record_type-1">DataAwsRoute53TrafficPolicyDocument#record_type</a>.
        /// </summary>
        [<CustomOperation "record_type">]
        member _.RecordType(state: DataAwsRoute53TrafficPolicyDocumentState, value: string) : DataAwsRoute53TrafficPolicyDocumentState =
            state.assignments.Add(fun config -> config.RecordType <- value)
            state : DataAwsRoute53TrafficPolicyDocumentState

        /// <summary>
        /// rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#rule-1">DataAwsRoute53TrafficPolicyDocument#rule</a> Accepts: aws.IResolvable | aws.DataAwsRoute53TrafficPolicyDocument.DataAwsRoute53TrafficPolicyDocumentRule[]
        /// </summary>
        [<CustomOperation "rule">]
        member _.Rule(state: DataAwsRoute53TrafficPolicyDocumentState, value: HashiCorp.Cdktf.IResolvable) : DataAwsRoute53TrafficPolicyDocumentState =
            state.assignments.Add(fun config -> config.Rule <- value)
            state : DataAwsRoute53TrafficPolicyDocumentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#start_endpoint-1">DataAwsRoute53TrafficPolicyDocument#start_endpoint</a>.
        /// </summary>
        [<CustomOperation "start_endpoint">]
        member _.StartEndpoint(state: DataAwsRoute53TrafficPolicyDocumentState, value: string) : DataAwsRoute53TrafficPolicyDocumentState =
            state.assignments.Add(fun config -> config.StartEndpoint <- value)
            state : DataAwsRoute53TrafficPolicyDocumentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#start_rule-1">DataAwsRoute53TrafficPolicyDocument#start_rule</a>.
        /// </summary>
        [<CustomOperation "start_rule">]
        member _.StartRule(state: DataAwsRoute53TrafficPolicyDocumentState, value: string) : DataAwsRoute53TrafficPolicyDocumentState =
            state.assignments.Add(fun config -> config.StartRule <- value)
            state : DataAwsRoute53TrafficPolicyDocumentState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route53_traffic_policy_document#version-1">DataAwsRoute53TrafficPolicyDocument#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: DataAwsRoute53TrafficPolicyDocumentState, value: string) : DataAwsRoute53TrafficPolicyDocumentState =
            state.assignments.Add(fun config -> config.Version <- value)
            state : DataAwsRoute53TrafficPolicyDocumentState

        member _.Run(state: DataAwsRoute53TrafficPolicyDocumentState) : aws.DataAwsRoute53TrafficPolicyDocument.DataAwsRoute53TrafficPolicyDocument =
            let config = aws.DataAwsRoute53TrafficPolicyDocument.DataAwsRoute53TrafficPolicyDocumentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRoute53TrafficPolicyDocument.DataAwsRoute53TrafficPolicyDocument(StackContext.get (), logicalId, config)
