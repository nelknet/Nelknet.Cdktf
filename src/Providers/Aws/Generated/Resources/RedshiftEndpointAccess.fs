namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, 'SubnetGroupName> = { assignments: ResizeArray<aws.RedshiftEndpointAccess.RedshiftEndpointAccessConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_access">aws_redshift_endpoint_access</a>.
    /// </summary>
    type RedshiftEndpointAccessBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftEndpointAccessState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftEndpointAccessState<Missing, Missing, Missing>)

        member _.Zero(()) : RedshiftEndpointAccessState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftEndpointAccessState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_access#cluster_identifier-1">RedshiftEndpointAccess#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RedshiftEndpointAccessState<Missing, 'EndpointName, 'SubnetGroupName>, value: string) : RedshiftEndpointAccessState<Present, 'EndpointName, 'SubnetGroupName> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftEndpointAccessState<Present, 'EndpointName, 'SubnetGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_access#endpoint_name-1">RedshiftEndpointAccess#endpoint_name</a>.
        /// </summary>
        [<CustomOperation "endpoint_name">]
        member _.EndpointName(state: RedshiftEndpointAccessState<'ClusterIdentifier, Missing, 'SubnetGroupName>, value: string) : RedshiftEndpointAccessState<'ClusterIdentifier, Present, 'SubnetGroupName> =
            state.assignments.Add(fun config -> config.EndpointName <- value)
            ({ assignments = state.assignments } : RedshiftEndpointAccessState<'ClusterIdentifier, Present, 'SubnetGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_access#subnet_group_name-1">RedshiftEndpointAccess#subnet_group_name</a>.
        /// </summary>
        [<CustomOperation "subnet_group_name">]
        member _.SubnetGroupName(state: RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, Missing>, value: string) : RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, Present> =
            state.assignments.Add(fun config -> config.SubnetGroupName <- value)
            ({ assignments = state.assignments } : RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_access#id-1">RedshiftEndpointAccess#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, 'SubnetGroupName>, value: string) : RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, 'SubnetGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, 'SubnetGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_access#resource_owner-1">RedshiftEndpointAccess#resource_owner</a>.
        /// </summary>
        [<CustomOperation "resource_owner">]
        member _.ResourceOwner(state: RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, 'SubnetGroupName>, value: string) : RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, 'SubnetGroupName> =
            state.assignments.Add(fun config -> config.ResourceOwner <- value)
            state : RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, 'SubnetGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_endpoint_access#vpc_security_group_ids-1">RedshiftEndpointAccess#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, 'SubnetGroupName>, value: seq<string>) : RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, 'SubnetGroupName> =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : RedshiftEndpointAccessState<'ClusterIdentifier, 'EndpointName, 'SubnetGroupName>

        member _.Run(state: RedshiftEndpointAccessState<Present, Present, Present>) : aws.RedshiftEndpointAccess.RedshiftEndpointAccess =
            let config = aws.RedshiftEndpointAccess.RedshiftEndpointAccessConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftEndpointAccess.RedshiftEndpointAccess(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftEndpointAccess: missing required arguments. Must call: cluster_identifier, endpoint_name, subnet_group_name.", 9999, IsError = true)>]
        member _.Run(_: RedshiftEndpointAccessState<_, _, _>) : aws.RedshiftEndpointAccess.RedshiftEndpointAccess =
            Unchecked.defaultof<aws.RedshiftEndpointAccess.RedshiftEndpointAccess>
