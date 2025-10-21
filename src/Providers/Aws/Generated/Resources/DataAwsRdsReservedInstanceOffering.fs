namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, 'MultiAz, 'OfferingType, 'ProductDescription> = { assignments: ResizeArray<aws.DataAwsRdsReservedInstanceOffering.DataAwsRdsReservedInstanceOfferingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_reserved_instance_offering">aws_rds_reserved_instance_offering</a>.
    /// </summary>
    type DataAwsRdsReservedInstanceOfferingBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsRdsReservedInstanceOfferingState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsRdsReservedInstanceOfferingState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsRdsReservedInstanceOfferingState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsRdsReservedInstanceOfferingState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_reserved_instance_offering#db_instance_class-1">DataAwsRdsReservedInstanceOffering#db_instance_class</a>.
        /// </summary>
        [<CustomOperation "db_instance_class">]
        member _.DbInstanceClass(state: DataAwsRdsReservedInstanceOfferingState<Missing, 'Duration, 'MultiAz, 'OfferingType, 'ProductDescription>, value: string) : DataAwsRdsReservedInstanceOfferingState<Present, 'Duration, 'MultiAz, 'OfferingType, 'ProductDescription> =
            state.assignments.Add(fun config -> config.DbInstanceClass <- value)
            ({ assignments = state.assignments } : DataAwsRdsReservedInstanceOfferingState<Present, 'Duration, 'MultiAz, 'OfferingType, 'ProductDescription>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_reserved_instance_offering#duration-1">DataAwsRdsReservedInstanceOffering#duration</a>.
        /// </summary>
        [<CustomOperation "duration">]
        member _.Duration(state: DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, Missing, 'MultiAz, 'OfferingType, 'ProductDescription>, value: double) : DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, Present, 'MultiAz, 'OfferingType, 'ProductDescription> =
            state.assignments.Add(fun config -> config.Duration <- value)
            ({ assignments = state.assignments } : DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, Present, 'MultiAz, 'OfferingType, 'ProductDescription>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_reserved_instance_offering#multi_az-1">DataAwsRdsReservedInstanceOffering#multi_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_az">]
        member _.MultiAz(state: DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, Missing, 'OfferingType, 'ProductDescription>, value: bool) : DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, Present, 'OfferingType, 'ProductDescription> =
            state.assignments.Add(fun config -> config.MultiAz <- value)
            ({ assignments = state.assignments } : DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, Present, 'OfferingType, 'ProductDescription>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_reserved_instance_offering#multi_az-1">DataAwsRdsReservedInstanceOffering#multi_az</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "multi_az">]
        member _.MultiAz(state: DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, Missing, 'OfferingType, 'ProductDescription>, value: HashiCorp.Cdktf.IResolvable) : DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, Present, 'OfferingType, 'ProductDescription> =
            state.assignments.Add(fun config -> config.MultiAz <- value)
            ({ assignments = state.assignments } : DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, Present, 'OfferingType, 'ProductDescription>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_reserved_instance_offering#offering_type-1">DataAwsRdsReservedInstanceOffering#offering_type</a>.
        /// </summary>
        [<CustomOperation "offering_type">]
        member _.OfferingType(state: DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, 'MultiAz, Missing, 'ProductDescription>, value: string) : DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, 'MultiAz, Present, 'ProductDescription> =
            state.assignments.Add(fun config -> config.OfferingType <- value)
            ({ assignments = state.assignments } : DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, 'MultiAz, Present, 'ProductDescription>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_reserved_instance_offering#product_description-1">DataAwsRdsReservedInstanceOffering#product_description</a>.
        /// </summary>
        [<CustomOperation "product_description">]
        member _.ProductDescription(state: DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, 'MultiAz, 'OfferingType, Missing>, value: string) : DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, 'MultiAz, 'OfferingType, Present> =
            state.assignments.Add(fun config -> config.ProductDescription <- value)
            ({ assignments = state.assignments } : DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, 'MultiAz, 'OfferingType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/rds_reserved_instance_offering#id-1">DataAwsRdsReservedInstanceOffering#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, 'MultiAz, 'OfferingType, 'ProductDescription>, value: string) : DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, 'MultiAz, 'OfferingType, 'ProductDescription> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsRdsReservedInstanceOfferingState<'DbInstanceClass, 'Duration, 'MultiAz, 'OfferingType, 'ProductDescription>

        member _.Run(state: DataAwsRdsReservedInstanceOfferingState<Present, Present, Present, Present, Present>) : aws.DataAwsRdsReservedInstanceOffering.DataAwsRdsReservedInstanceOffering =
            let config = aws.DataAwsRdsReservedInstanceOffering.DataAwsRdsReservedInstanceOfferingConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsRdsReservedInstanceOffering.DataAwsRdsReservedInstanceOffering(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsRdsReservedInstanceOffering: missing required arguments. Must call: db_instance_class, duration, multi_az, offering_type, product_description.", 9999, IsError = true)>]
        member _.Run(_: DataAwsRdsReservedInstanceOfferingState<_, _, _, _, _>) : aws.DataAwsRdsReservedInstanceOffering.DataAwsRdsReservedInstanceOffering =
            Unchecked.defaultof<aws.DataAwsRdsReservedInstanceOffering.DataAwsRdsReservedInstanceOffering>
