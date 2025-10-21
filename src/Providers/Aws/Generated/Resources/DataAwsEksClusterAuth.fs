namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEksClusterAuthState<'Name> = { assignments: ResizeArray<aws.DataAwsEksClusterAuth.DataAwsEksClusterAuthConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster_auth">aws_eks_cluster_auth</a>.
    /// </summary>
    type DataAwsEksClusterAuthBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEksClusterAuthState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksClusterAuthState<Missing>)

        member _.Zero(()) : DataAwsEksClusterAuthState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEksClusterAuthState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster_auth#name-1">DataAwsEksClusterAuth#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsEksClusterAuthState<Missing>, value: string) : DataAwsEksClusterAuthState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsEksClusterAuthState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/eks_cluster_auth#id-1">DataAwsEksClusterAuth#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEksClusterAuthState<'Name>, value: string) : DataAwsEksClusterAuthState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEksClusterAuthState<'Name>

        member _.Run(state: DataAwsEksClusterAuthState<Present>) : aws.DataAwsEksClusterAuth.DataAwsEksClusterAuth =
            let config = aws.DataAwsEksClusterAuth.DataAwsEksClusterAuthConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEksClusterAuth.DataAwsEksClusterAuth(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEksClusterAuth: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEksClusterAuthState<_>) : aws.DataAwsEksClusterAuth.DataAwsEksClusterAuth =
            Unchecked.defaultof<aws.DataAwsEksClusterAuth.DataAwsEksClusterAuth>
