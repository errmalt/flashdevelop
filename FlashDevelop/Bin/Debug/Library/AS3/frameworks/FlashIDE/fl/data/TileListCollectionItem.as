﻿package fl.data
{
	/**
	 * The TileListCollectionItem class defines a single item in an inspectable
	 */
	public dynamic class TileListCollectionItem
	{
		/**
		 * The <code>label</code> property of the object.
		 */
		public var label : String;
		/**
		 * The <code>source</code> property of the object. This can be the path or a class
		 */
		public var source : String;

		/**
		 * Creates a new TileListCollectionItem object.
		 */
		public function TileListCollectionItem ();
		/**
		 * @private
		 */
		public function toString () : String;
	}
}