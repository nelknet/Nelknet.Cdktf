namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsIamServerCertificateState = { assignments: ResizeArray<aws.DataAwsIamServerCertificate.DataAwsIamServerCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_server_certificate">aws_iam_server_certificate</a>.
    /// </summary>
    type DataAwsIamServerCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsIamServerCertificateState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsIamServerCertificateState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_server_certificate#id-1">DataAwsIamServerCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsIamServerCertificateState, value: string) : DataAwsIamServerCertificateState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsIamServerCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_server_certificate#latest-1">DataAwsIamServerCertificate#latest</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "latest">]
        member _.Latest(state: DataAwsIamServerCertificateState, value: bool) : DataAwsIamServerCertificateState =
            state.assignments.Add(fun config -> config.Latest <- value)
            state : DataAwsIamServerCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_server_certificate#latest-1">DataAwsIamServerCertificate#latest</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "latest">]
        member _.Latest(state: DataAwsIamServerCertificateState, value: HashiCorp.Cdktf.IResolvable) : DataAwsIamServerCertificateState =
            state.assignments.Add(fun config -> config.Latest <- value)
            state : DataAwsIamServerCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_server_certificate#name-1">DataAwsIamServerCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsIamServerCertificateState, value: string) : DataAwsIamServerCertificateState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsIamServerCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_server_certificate#name_prefix-1">DataAwsIamServerCertificate#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: DataAwsIamServerCertificateState, value: string) : DataAwsIamServerCertificateState =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : DataAwsIamServerCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/iam_server_certificate#path_prefix-1">DataAwsIamServerCertificate#path_prefix</a>.
        /// </summary>
        [<CustomOperation "path_prefix">]
        member _.PathPrefix(state: DataAwsIamServerCertificateState, value: string) : DataAwsIamServerCertificateState =
            state.assignments.Add(fun config -> config.PathPrefix <- value)
            state : DataAwsIamServerCertificateState

        member _.Run(state: DataAwsIamServerCertificateState) : aws.DataAwsIamServerCertificate.DataAwsIamServerCertificate =
            let config = aws.DataAwsIamServerCertificate.DataAwsIamServerCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsIamServerCertificate.DataAwsIamServerCertificate(StackContext.get (), logicalId, config)
