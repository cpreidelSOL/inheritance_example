import sys

class BuildingElement: 
    def __init__(self, fname):
        self.name = fname
    
    def printname(self):
        print('My name is = ' + self.name)
    
class Wall(BuildingElement): 
    
        def __init__(self, fname, fthickness):
            super().__init__(fname)
            self.thickness = fthickness
            
        def printname(self):
                print('My name is = ' + self.name + ' und meine Dicke ist ' + str(self.thickness))
                
x = Wall("Wand", 1.12)
x.printname()