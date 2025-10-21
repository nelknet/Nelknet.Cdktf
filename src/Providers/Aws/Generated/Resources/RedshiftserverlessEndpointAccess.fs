namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, 'WorkgroupName> = { assignments: ResizeArray<aws.RedshiftserverlessEndpointAccess.RedshiftserverlessEndpointAccessConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_endpoint_access">aws_redshiftserverless_endpoint_access</a>.
    /// </summary>
    type RedshiftserverlessEndpointAccessBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftserverlessEndpointAccessState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessEndpointAccessState<Missing, Missing, Missing>)

        member _.Zero(()) : RedshiftserverlessEndpointAccessState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessEndpointAccessState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_endpoint_access#endpoint_name-1">RedshiftserverlessEndpointAccess#endpoint_name</a>.
        /// </summary>
        [<CustomOperation "endpoint_name">]
        member _.EndpointName(state: RedshiftserverlessEndpointAccessState<Missing, 'SubnetIds, 'WorkgroupName>, value: string) : RedshiftserverlessEndpointAccessState<Present, 'SubnetIds, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.EndpointName <- value)
            ({ assignments = state.assignments } : RedshiftserverlessEndpointAccessState<Present, 'SubnetIds, 'WorkgroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_endpoint_access#subnet_ids-1">RedshiftserverlessEndpointAccess#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: RedshiftserverlessEndpointAccessState<'EndpointName, Missing, 'WorkgroupName>, value: seq<string>) : RedshiftserverlessEndpointAccessState<'EndpointName, Present, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : RedshiftserverlessEndpointAccessState<'EndpointName, Present, 'WorkgroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_endpoint_access#workgroup_name-1">RedshiftserverlessEndpointAccess#workgroup_name</a>.
        /// </summary>
        [<CustomOperation "workgroup_name">]
        member _.WorkgroupName(state: RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, Missing>, value: string) : RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, Present> =
            state.assignments.Add(fun config -> config.WorkgroupName <- value)
            ({ assignments = state.assignments } : RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_endpoint_access#id-1">RedshiftserverlessEndpointAccess#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, 'WorkgroupName>, value: string) : RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_endpoint_access#owner_account-1">RedshiftserverlessEndpointAccess#owner_account</a>.
        /// </summary>
        [<CustomOperation "owner_account">]
        member _.OwnerAccount(state: RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, 'WorkgroupName>, value: string) : RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.OwnerAccount <- value)
            state : RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_endpoint_access#vpc_security_group_ids-1">RedshiftserverlessEndpointAccess#vpc_security_group_ids</a>.
        /// </summary>
        [<CustomOperation "vpc_security_group_ids">]
        member _.VpcSecurityGroupIds(state: RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, 'WorkgroupName>, value: seq<string>) : RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.VpcSecurityGroupIds <- (value |> Seq.toArray))
            state : RedshiftserverlessEndpointAccessState<'EndpointName, 'SubnetIds, 'WorkgroupName>

        member _.Run(state: RedshiftserverlessEndpointAccessState<Present, Present, Present>) : aws.RedshiftserverlessEndpointAccess.RedshiftserverlessEndpointAccess =
            let config = aws.RedshiftserverlessEndpointAccess.RedshiftserverlessEndpointAccessConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftserverlessEndpointAccess.RedshiftserverlessEndpointAccess(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftserverlessEndpointAccess: missing required arguments. Must call: endpoint_name, subnet_ids, workgroup_name.", 9999, IsError = true)>]
        member _.Run(_: RedshiftserverlessEndpointAccessState<_, _, _>) : aws.RedshiftserverlessEndpointAccess.RedshiftserverlessEndpointAccess =
            Unchecked.defaultof<aws.RedshiftserverlessEndpointAccess.RedshiftserverlessEndpointAccess>
