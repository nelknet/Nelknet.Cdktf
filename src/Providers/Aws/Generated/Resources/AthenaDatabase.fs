namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AthenaDatabaseState<'Name> = { assignments: ResizeArray<aws.AthenaDatabase.AthenaDatabaseConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database">aws_athena_database</a>.
    /// </summary>
    type AthenaDatabaseBuilder(logicalId: string) =
        member _.Yield(_: unit) : AthenaDatabaseState<Missing> =
            ({ assignments = ResizeArray() } : AthenaDatabaseState<Missing>)

        member _.Zero(()) : AthenaDatabaseState<Missing> =
            ({ assignments = ResizeArray() } : AthenaDatabaseState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#name-1">AthenaDatabase#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AthenaDatabaseState<Missing>, value: string) : AthenaDatabaseState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AthenaDatabaseState<Present>)

        /// <summary>
        /// acl_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#acl_configuration-1">AthenaDatabase#acl_configuration</a>
        /// </summary>
        [<CustomOperation "acl_configuration">]
        member _.AclConfiguration(state: AthenaDatabaseState<'Name>, value: aws.AthenaDatabase.AthenaDatabaseAclConfiguration) : AthenaDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.AclConfiguration <- value)
            state : AthenaDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#bucket-1">AthenaDatabase#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: AthenaDatabaseState<'Name>, value: string) : AthenaDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            state : AthenaDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#comment-1">AthenaDatabase#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: AthenaDatabaseState<'Name>, value: string) : AthenaDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : AthenaDatabaseState<'Name>

        /// <summary>
        /// encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#encryption_configuration-1">AthenaDatabase#encryption_configuration</a>
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: AthenaDatabaseState<'Name>, value: aws.AthenaDatabase.AthenaDatabaseEncryptionConfiguration) : AthenaDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : AthenaDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#expected_bucket_owner-1">AthenaDatabase#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: AthenaDatabaseState<'Name>, value: string) : AthenaDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : AthenaDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#force_destroy-1">AthenaDatabase#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: AthenaDatabaseState<'Name>, value: bool) : AthenaDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : AthenaDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#force_destroy-1">AthenaDatabase#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: AthenaDatabaseState<'Name>, value: HashiCorp.Cdktf.IResolvable) : AthenaDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : AthenaDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#id-1">AthenaDatabase#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AthenaDatabaseState<'Name>, value: string) : AthenaDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AthenaDatabaseState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/athena_database#properties-1">AthenaDatabase#properties</a>.
        /// </summary>
        [<CustomOperation "properties">]
        member _.Properties(state: AthenaDatabaseState<'Name>, value: seq<string * string>) : AthenaDatabaseState<'Name> =
            state.assignments.Add(fun config -> config.Properties <- dict value)
            state : AthenaDatabaseState<'Name>

        member _.Run(state: AthenaDatabaseState<Present>) : aws.AthenaDatabase.AthenaDatabase =
            let config = aws.AthenaDatabase.AthenaDatabaseConfig()
            for setter in state.assignments do
                setter config
            aws.AthenaDatabase.AthenaDatabase(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.athenaDatabase: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: AthenaDatabaseState<_>) : aws.AthenaDatabase.AthenaDatabase =
            Unchecked.defaultof<aws.AthenaDatabase.AthenaDatabase>
