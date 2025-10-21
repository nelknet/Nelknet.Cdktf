namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamServerCertificateState<'CertificateBody, 'PrivateKey> = { assignments: ResizeArray<aws.IamServerCertificate.IamServerCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate">aws_iam_server_certificate</a>.
    /// </summary>
    type IamServerCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamServerCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamServerCertificateState<Missing, Missing>)

        member _.Zero(()) : IamServerCertificateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IamServerCertificateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#certificate_body-1">IamServerCertificate#certificate_body</a>.
        /// </summary>
        [<CustomOperation "certificate_body">]
        member _.CertificateBody(state: IamServerCertificateState<Missing, 'PrivateKey>, value: string) : IamServerCertificateState<Present, 'PrivateKey> =
            state.assignments.Add(fun config -> config.CertificateBody <- value)
            ({ assignments = state.assignments } : IamServerCertificateState<Present, 'PrivateKey>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#private_key-1">IamServerCertificate#private_key</a>.
        /// </summary>
        [<CustomOperation "private_key">]
        member _.PrivateKey(state: IamServerCertificateState<'CertificateBody, Missing>, value: string) : IamServerCertificateState<'CertificateBody, Present> =
            state.assignments.Add(fun config -> config.PrivateKey <- value)
            ({ assignments = state.assignments } : IamServerCertificateState<'CertificateBody, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#certificate_chain-1">IamServerCertificate#certificate_chain</a>.
        /// </summary>
        [<CustomOperation "certificate_chain">]
        member _.CertificateChain(state: IamServerCertificateState<'CertificateBody, 'PrivateKey>, value: string) : IamServerCertificateState<'CertificateBody, 'PrivateKey> =
            state.assignments.Add(fun config -> config.CertificateChain <- value)
            state : IamServerCertificateState<'CertificateBody, 'PrivateKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#id-1">IamServerCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IamServerCertificateState<'CertificateBody, 'PrivateKey>, value: string) : IamServerCertificateState<'CertificateBody, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IamServerCertificateState<'CertificateBody, 'PrivateKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#name-1">IamServerCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IamServerCertificateState<'CertificateBody, 'PrivateKey>, value: string) : IamServerCertificateState<'CertificateBody, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : IamServerCertificateState<'CertificateBody, 'PrivateKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#name_prefix-1">IamServerCertificate#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: IamServerCertificateState<'CertificateBody, 'PrivateKey>, value: string) : IamServerCertificateState<'CertificateBody, 'PrivateKey> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : IamServerCertificateState<'CertificateBody, 'PrivateKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#path-1">IamServerCertificate#path</a>.
        /// </summary>
        [<CustomOperation "path">]
        member _.Path(state: IamServerCertificateState<'CertificateBody, 'PrivateKey>, value: string) : IamServerCertificateState<'CertificateBody, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Path <- value)
            state : IamServerCertificateState<'CertificateBody, 'PrivateKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#tags-1">IamServerCertificate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IamServerCertificateState<'CertificateBody, 'PrivateKey>, value: seq<string * string>) : IamServerCertificateState<'CertificateBody, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IamServerCertificateState<'CertificateBody, 'PrivateKey>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#tags_all-1">IamServerCertificate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IamServerCertificateState<'CertificateBody, 'PrivateKey>, value: seq<string * string>) : IamServerCertificateState<'CertificateBody, 'PrivateKey> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IamServerCertificateState<'CertificateBody, 'PrivateKey>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#timeouts-1">IamServerCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IamServerCertificateState<'CertificateBody, 'PrivateKey>, value: aws.IamServerCertificate.IamServerCertificateTimeouts) : IamServerCertificateState<'CertificateBody, 'PrivateKey> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IamServerCertificateState<'CertificateBody, 'PrivateKey>

        member _.Run(state: IamServerCertificateState<Present, Present>) : aws.IamServerCertificate.IamServerCertificate =
            let config = aws.IamServerCertificate.IamServerCertificateConfig()
            for setter in state.assignments do
                setter config
            aws.IamServerCertificate.IamServerCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamServerCertificate: missing required arguments. Must call: certificate_body, private_key.", 9999, IsError = true)>]
        member _.Run(_: IamServerCertificateState<_, _>) : aws.IamServerCertificate.IamServerCertificate =
            Unchecked.defaultof<aws.IamServerCertificate.IamServerCertificate>
