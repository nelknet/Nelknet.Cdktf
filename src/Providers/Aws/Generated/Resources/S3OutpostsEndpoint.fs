namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, 'SubnetId> = { assignments: ResizeArray<aws.S3OutpostsEndpoint.S3OutpostsEndpointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3outposts_endpoint">aws_s3outposts_endpoint</a>.
    /// </summary>
    type S3OutpostsEndpointBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3OutpostsEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3OutpostsEndpointState<Missing, Missing, Missing>)

        member _.Zero(()) : S3OutpostsEndpointState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3OutpostsEndpointState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3outposts_endpoint#outpost_id-1">S3OutpostsEndpoint#outpost_id</a>.
        /// </summary>
        [<CustomOperation "outpost_id">]
        member _.OutpostId(state: S3OutpostsEndpointState<Missing, 'SecurityGroupId, 'SubnetId>, value: string) : S3OutpostsEndpointState<Present, 'SecurityGroupId, 'SubnetId> =
            state.assignments.Add(fun config -> config.OutpostId <- value)
            ({ assignments = state.assignments } : S3OutpostsEndpointState<Present, 'SecurityGroupId, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3outposts_endpoint#security_group_id-1">S3OutpostsEndpoint#security_group_id</a>.
        /// </summary>
        [<CustomOperation "security_group_id">]
        member _.SecurityGroupId(state: S3OutpostsEndpointState<'OutpostId, Missing, 'SubnetId>, value: string) : S3OutpostsEndpointState<'OutpostId, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.SecurityGroupId <- value)
            ({ assignments = state.assignments } : S3OutpostsEndpointState<'OutpostId, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3outposts_endpoint#subnet_id-1">S3OutpostsEndpoint#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, Missing>, value: string) : S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3outposts_endpoint#access_type-1">S3OutpostsEndpoint#access_type</a>.
        /// </summary>
        [<CustomOperation "access_type">]
        member _.AccessType(state: S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, 'SubnetId>, value: string) : S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, 'SubnetId> =
            state.assignments.Add(fun config -> config.AccessType <- value)
            state : S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3outposts_endpoint#customer_owned_ipv4_pool-1">S3OutpostsEndpoint#customer_owned_ipv4_pool</a>.
        /// </summary>
        [<CustomOperation "customer_owned_ipv4_pool">]
        member _.CustomerOwnedIpv4Pool(state: S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, 'SubnetId>, value: string) : S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, 'SubnetId> =
            state.assignments.Add(fun config -> config.CustomerOwnedIpv4Pool <- value)
            state : S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3outposts_endpoint#id-1">S3OutpostsEndpoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, 'SubnetId>, value: string) : S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3OutpostsEndpointState<'OutpostId, 'SecurityGroupId, 'SubnetId>

        member _.Run(state: S3OutpostsEndpointState<Present, Present, Present>) : aws.S3OutpostsEndpoint.S3OutpostsEndpoint =
            let config = aws.S3OutpostsEndpoint.S3OutpostsEndpointConfig()
            for setter in state.assignments do
                setter config
            aws.S3OutpostsEndpoint.S3OutpostsEndpoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3OutpostsEndpoint: missing required arguments. Must call: outpost_id, security_group_id, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: S3OutpostsEndpointState<_, _, _>) : aws.S3OutpostsEndpoint.S3OutpostsEndpoint =
            Unchecked.defaultof<aws.S3OutpostsEndpoint.S3OutpostsEndpoint>
