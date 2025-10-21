namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsAcmCertificateState = { assignments: ResizeArray<aws.DataAwsAcmCertificate.DataAwsAcmCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acm_certificate">aws_acm_certificate</a>.
    /// </summary>
    type DataAwsAcmCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsAcmCertificateState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsAcmCertificateState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acm_certificate#domain-1">DataAwsAcmCertificate#domain</a>.
        /// </summary>
        [<CustomOperation "domain">]
        member _.Domain(state: DataAwsAcmCertificateState, value: string) : DataAwsAcmCertificateState =
            state.assignments.Add(fun config -> config.Domain <- value)
            state : DataAwsAcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acm_certificate#id-1">DataAwsAcmCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsAcmCertificateState, value: string) : DataAwsAcmCertificateState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsAcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acm_certificate#key_types-1">DataAwsAcmCertificate#key_types</a>.
        /// </summary>
        [<CustomOperation "key_types">]
        member _.KeyTypes(state: DataAwsAcmCertificateState, value: seq<string>) : DataAwsAcmCertificateState =
            state.assignments.Add(fun config -> config.KeyTypes <- (value |> Seq.toArray))
            state : DataAwsAcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acm_certificate#most_recent-1">DataAwsAcmCertificate#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsAcmCertificateState, value: bool) : DataAwsAcmCertificateState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsAcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acm_certificate#most_recent-1">DataAwsAcmCertificate#most_recent</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "most_recent">]
        member _.MostRecent(state: DataAwsAcmCertificateState, value: HashiCorp.Cdktf.IResolvable) : DataAwsAcmCertificateState =
            state.assignments.Add(fun config -> config.MostRecent <- value)
            state : DataAwsAcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acm_certificate#statuses-1">DataAwsAcmCertificate#statuses</a>.
        /// </summary>
        [<CustomOperation "statuses">]
        member _.Statuses(state: DataAwsAcmCertificateState, value: seq<string>) : DataAwsAcmCertificateState =
            state.assignments.Add(fun config -> config.Statuses <- (value |> Seq.toArray))
            state : DataAwsAcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acm_certificate#tags-1">DataAwsAcmCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsAcmCertificateState, value: seq<string * string>) : DataAwsAcmCertificateState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsAcmCertificateState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/acm_certificate#types-1">DataAwsAcmCertificate#types</a>.
        /// </summary>
        [<CustomOperation "types">]
        member _.Types(state: DataAwsAcmCertificateState, value: seq<string>) : DataAwsAcmCertificateState =
            state.assignments.Add(fun config -> config.Types <- (value |> Seq.toArray))
            state : DataAwsAcmCertificateState

        member _.Run(state: DataAwsAcmCertificateState) : aws.DataAwsAcmCertificate.DataAwsAcmCertificate =
            let config = aws.DataAwsAcmCertificate.DataAwsAcmCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsAcmCertificate.DataAwsAcmCertificate(StackContext.get (), logicalId, config)
