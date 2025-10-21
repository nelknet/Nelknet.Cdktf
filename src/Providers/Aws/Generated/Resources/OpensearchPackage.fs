namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OpensearchPackageState<'PackageName, 'PackageSource, 'PackageType> = { assignments: ResizeArray<aws.OpensearchPackage.OpensearchPackageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package">aws_opensearch_package</a>.
    /// </summary>
    type OpensearchPackageBuilder(logicalId: string) =
        member _.Yield(_: unit) : OpensearchPackageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchPackageState<Missing, Missing, Missing>)

        member _.Zero(()) : OpensearchPackageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : OpensearchPackageState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package#package_name-1">OpensearchPackage#package_name</a>.
        /// </summary>
        [<CustomOperation "package_name">]
        member _.PackageName(state: OpensearchPackageState<Missing, 'PackageSource, 'PackageType>, value: string) : OpensearchPackageState<Present, 'PackageSource, 'PackageType> =
            state.assignments.Add(fun config -> config.PackageName <- value)
            ({ assignments = state.assignments } : OpensearchPackageState<Present, 'PackageSource, 'PackageType>)

        /// <summary>
        /// package_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package#package_source-1">OpensearchPackage#package_source</a>
        /// </summary>
        [<CustomOperation "package_source">]
        member _.PackageSource(state: OpensearchPackageState<'PackageName, Missing, 'PackageType>, value: aws.OpensearchPackage.OpensearchPackagePackageSource) : OpensearchPackageState<'PackageName, Present, 'PackageType> =
            state.assignments.Add(fun config -> config.PackageSource <- value)
            ({ assignments = state.assignments } : OpensearchPackageState<'PackageName, Present, 'PackageType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package#package_type-1">OpensearchPackage#package_type</a>.
        /// </summary>
        [<CustomOperation "package_type">]
        member _.PackageType(state: OpensearchPackageState<'PackageName, 'PackageSource, Missing>, value: string) : OpensearchPackageState<'PackageName, 'PackageSource, Present> =
            state.assignments.Add(fun config -> config.PackageType <- value)
            ({ assignments = state.assignments } : OpensearchPackageState<'PackageName, 'PackageSource, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package#id-1">OpensearchPackage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OpensearchPackageState<'PackageName, 'PackageSource, 'PackageType>, value: string) : OpensearchPackageState<'PackageName, 'PackageSource, 'PackageType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OpensearchPackageState<'PackageName, 'PackageSource, 'PackageType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/opensearch_package#package_description-1">OpensearchPackage#package_description</a>.
        /// </summary>
        [<CustomOperation "package_description">]
        member _.PackageDescription(state: OpensearchPackageState<'PackageName, 'PackageSource, 'PackageType>, value: string) : OpensearchPackageState<'PackageName, 'PackageSource, 'PackageType> =
            state.assignments.Add(fun config -> config.PackageDescription <- value)
            state : OpensearchPackageState<'PackageName, 'PackageSource, 'PackageType>

        member _.Run(state: OpensearchPackageState<Present, Present, Present>) : aws.OpensearchPackage.OpensearchPackage =
            let config = aws.OpensearchPackage.OpensearchPackageConfig()
            for setter in state.assignments do
                setter config
            aws.OpensearchPackage.OpensearchPackage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.opensearchPackage: missing required arguments. Must call: package_name, package_source, package_type.", 9999, IsError = true)>]
        member _.Run(_: OpensearchPackageState<_, _, _>) : aws.OpensearchPackage.OpensearchPackage =
            Unchecked.defaultof<aws.OpensearchPackage.OpensearchPackage>
