String.prototype.half = function(){
    let lengthOfHalfString = Math.round((this.length/2));
    return this.substring(0, lengthOfHalfString )
}