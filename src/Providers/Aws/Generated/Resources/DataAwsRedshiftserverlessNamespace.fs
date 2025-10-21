namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRedshiftserverlessNamespaceState<'NamespaceName> = { assignments: ResizeArray<aws.DataAwsRedshiftserverlessNamespace.DataAwsRedshiftserverlessNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshiftserverless_namespace">aws_redshiftserverless_namespace</a>.
    /// </summary>
    type DataAwsRedshiftserverlessNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRedshiftserverlessNamespaceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftserverlessNamespaceState<Missing>)

        member _.Zero(()) : DataAwsRedshiftserverlessNamespaceState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsRedshiftserverlessNamespaceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshiftserverless_namespace#namespace_name-1">DataAwsRedshiftserverlessNamespace#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: DataAwsRedshiftserverlessNamespaceState<Missing>, value: string) : DataAwsRedshiftserverlessNamespaceState<Present> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : DataAwsRedshiftserverlessNamespaceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/redshiftserverless_namespace#id-1">DataAwsRedshiftserverlessNamespace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRedshiftserverlessNamespaceState<'NamespaceName>, value: string) : DataAwsRedshiftserverlessNamespaceState<'NamespaceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRedshiftserverlessNamespaceState<'NamespaceName>

        member _.Run(state: DataAwsRedshiftserverlessNamespaceState<Present>) : aws.DataAwsRedshiftserverlessNamespace.DataAwsRedshiftserverlessNamespace =
            let config = aws.DataAwsRedshiftserverlessNamespace.DataAwsRedshiftserverlessNamespaceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRedshiftserverlessNamespace.DataAwsRedshiftserverlessNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRedshiftserverlessNamespace: missing required arguments. Must call: namespace_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRedshiftserverlessNamespaceState<_>) : aws.DataAwsRedshiftserverlessNamespace.DataAwsRedshiftserverlessNamespace =
            Unchecked.defaultof<aws.DataAwsRedshiftserverlessNamespace.DataAwsRedshiftserverlessNamespace>
